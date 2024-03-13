using Core.Effects.TakeDamage;

namespace Core.Handlers.Logic.Effects
{
    public sealed class DamageAbsorptionEffectHandler: BaseHandler<DamageAbsorptionEffect>
    {
        public DamageAbsorptionEffectHandler(EventBus.EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(DamageAbsorptionEffect evt)
        {
            if (evt.Duration == 1)
            {
                evt.Source.RemoveEffect<DamageEvasionEffect>(evt);
            }

            evt.Duration--;
        }
    }
}