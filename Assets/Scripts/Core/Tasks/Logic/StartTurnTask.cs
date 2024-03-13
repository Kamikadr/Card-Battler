using System.Linq;
using Core.DataContainers;
using Core.Effects;
using Core.Events;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Core.Tasks.Logic
{
    public sealed class StartTurnTask: BaseTask
    {
        private readonly EventBus.EventBus _eventBus;
        private readonly IPlayerListenable _currentPlayer;
        private readonly IHeroChangeable _currentHero;

        public StartTurnTask(EventBus.EventBus eventBus ,IPlayerListenable currentPlayer, IHeroChangeable currentHero)
        {
            _eventBus = eventBus;
            _currentPlayer = currentPlayer;
            _currentHero = currentHero;
        }
        protected override UniTask OnRun()
        {
            Debug.Log("Start Turn");
            var hero = _currentPlayer.FriendHeroList.GetNext();
            
            while (hero.TryGetEffects<ImmovableEffect>(out var effects))
            {
                foreach (var effect in effects.ToArray())
                {
                    _eventBus.RaiseEvent(effect);
                }
                hero = _currentPlayer.FriendHeroList.GetNext();
            }

            
            _currentHero.Value = hero;
            _eventBus.RaiseEvent(new ActivityHeroEvent(hero, true));
            Finish();
            return UniTask.CompletedTask;
        }
    }
}