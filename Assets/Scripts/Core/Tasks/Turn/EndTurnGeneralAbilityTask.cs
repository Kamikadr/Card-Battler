using System.Collections.Generic;
using Core.Effects.EndTurnGeneral;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Core.Tasks
{
    public class EndTurnGeneralAbilityTask: BaseTask
    {
        private readonly EventBus _eventBus;
        private readonly IPlayerListenable _playerContainer;

        public EndTurnGeneralAbilityTask(EventBus eventBus, IPlayerListenable playerContainer)
        {
            _eventBus = eventBus;
            _playerContainer = playerContainer;
        }

        protected override UniTask OnRun()
        {
            Debug.Log("General End");
            var heroes = _playerContainer.FriendHeroList.GetAll();
            foreach (var hero in heroes)
            {
                var heroEffects = hero.GetEffects<EndTurnGeneralEffect>();
                foreach (var effect in heroEffects)
                {
                    _eventBus.RaiseEvent(effect);
                }
            }
            Finish();
            return UniTask.CompletedTask;
        }
    }
}