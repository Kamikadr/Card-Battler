using Core.Effects;

namespace Core.Handlers.Effects
{
    public class DamageAbsorptionEffectHandler: BaseHandler<DamageAbsorptionEffect>
    {
        public DamageAbsorptionEffectHandler(EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(DamageAbsorptionEffect evt)
        {
            if (evt.duration == 1)
            {
                evt.source.RemoveEffect<DamageEvasionEffect>(evt);
            }

            evt.duration--;
        }
    }
}