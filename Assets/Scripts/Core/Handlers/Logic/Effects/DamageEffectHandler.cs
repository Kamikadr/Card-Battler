using Core.Components;
using Core.Effects.Attack;
using Core.Events;

namespace Core.Handlers.Logic.Effects
{
    public sealed class DamageEffectHandler: BaseHandler<DamageEffect>
    {
        public DamageEffectHandler(EventBus.EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(DamageEffect evt)
        {
            var damageComponent = evt.Source.GetEntityComponent<DamageComponent>();
            EventBus.RaiseEvent(new DealDamageEvent(damageComponent.Value, evt.Target));
        }
    }
}