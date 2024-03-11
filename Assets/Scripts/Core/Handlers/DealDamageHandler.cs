using Core.Effects;
using Core.Events;

namespace Core.Handlers
{
    public class DealDamageHandler: BaseHandler<DealDamageEvent>
    {
        public DealDamageHandler(EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(DealDamageEvent evt)
        {
            if (evt.Target.TryGetEffects<DamageEvasionEffect>(out var evasionEffects))
            {
                foreach (var effect in evasionEffects)
                {
                    EventBus.RaiseEvent(effect);
                }
            }
            else
            {
                var health = evt.Target.GetEntityComponent<HealthComponent>();
                health.Value -= evt.Damage;
            }
        }
    }
}