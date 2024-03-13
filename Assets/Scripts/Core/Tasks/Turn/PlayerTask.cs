using System.Linq;
using Core.Components;
using Core.Effects;
using Core.Events;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Core.Tasks
{
    public class PlayerTask: BaseTask
    {
        private readonly EventBus _eventBus;
        private readonly HeroButtonListener _heroListeners;
        private readonly IHeroListenable _currentHero;
        private Team _currentHeroTeam;

        public PlayerTask(EventBus eventBus, HeroButtonListener heroListeners,
            IHeroListenable currentHero)
        {
            _eventBus = eventBus;
            _heroListeners = heroListeners;
            _currentHero = currentHero;
        }

        protected override UniTask OnRun()
        {
            Debug.Log("Player Turn");
            _heroListeners.OnEntityClick += OnEnemyHeroChoose;
            _currentHeroTeam = _currentHero.Value.GetEntityComponent<TeamComponent>().value;
            return UniTask.CompletedTask;
        }

        private void OnEnemyHeroChoose(HeroEntity target)
        {
            var targetTeam = target.GetEntityComponent<TeamComponent>();
            if (targetTeam.value == _currentHeroTeam || target.GetEffects<UntouchableEffect>().Any())
            {
                return;
            }
            
            var targetContainer = new HeroContainer{ Value = target };
            _eventBus.RaiseEvent(new PreAttackEvent(_currentHero, targetContainer));
            _eventBus.RaiseEvent(new AttackEvent(_currentHero, targetContainer));
            _eventBus.RaiseEvent(new BackAttackEvent(targetContainer, _currentHero));
            Finish();
        }

        protected override void OnFinished()
        {
            _heroListeners.OnEntityClick -= OnEnemyHeroChoose;
        }
    }
}