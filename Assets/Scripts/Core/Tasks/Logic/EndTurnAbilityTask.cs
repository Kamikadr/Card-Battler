using Core.DataContainers;
using Core.Effects.EndTurnEffect;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Core.Tasks.Logic
{
    public sealed class EndTurnAbilityTask: BaseTask
    {
        
        private readonly EventBus.EventBus _eventBus;
        private readonly IHeroListenable _heroContainer;

        public EndTurnAbilityTask(EventBus.EventBus eventBus, IHeroListenable heroContainer)
        {
            _eventBus = eventBus;
            _heroContainer = heroContainer;
        }

        protected override UniTask OnRun()
        {
            Debug.Log("End ability");
            var heroEffects = _heroContainer.Value.GetEffects<EndTurnEffect>();
            foreach (var effect in heroEffects)
            {
                _eventBus.RaiseEvent(effect);
            }
            Finish();
            return UniTask.CompletedTask;
        }
    }
}