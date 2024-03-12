using Core.Effects.EndTurnEffect;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Core.Tasks
{
    public class EndTurnAbilityTask: BaseTask
    {
        
        private readonly EventBus _eventBus;
        private readonly IHeroListenable _heroContainer;

        public EndTurnAbilityTask(EventBus eventBus, IHeroListenable heroContainer)
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