using Core.Components;
using Core.Effects;
using Core.Events;

namespace Core.Handlers.Effects
{
    public class DamageEffectHandler: BaseHandler<DamageEffect>
    {
        public DamageEffectHandler(EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(DamageEffect evt)
        {
            var damageComponent = evt.Source.GetEntityComponent<DamageComponent>();
            EventBus.RaiseEvent(new DealDamageEvent(damageComponent.Value, evt.Target));
        }
    }
}