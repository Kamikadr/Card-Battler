using Core.Components;
using Core.Effects;
using UnityEngine;

namespace Core.Handlers.Effects
{
    public class LifestealEffectHandler: BaseHandler<LifestealEffect>
    {
        public LifestealEffectHandler(EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(LifestealEffect evt)
        {
            var random = Random.value;
            if (random >= 0.5f)
            { 
                var damageComponent = evt.Source.GetEntityComponent<DamageComponent>();
                EventBus.RaiseEvent(new HealEvent(evt.Source, damageComponent.Value));
            }
        }
    }
}