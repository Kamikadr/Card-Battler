using System.Linq;
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
                foreach (var effect in evasionEffects.ToArray())
                {
                    EventBus.RaiseEvent(effect);
                }
            }
            else
            {
                var health = evt.Target.GetEntityComponent<HealthComponent>();
                health.currentHealth -= evt.Damage;
                if (health.currentHealth <= 0)
                {
                    EventBus.RaiseEvent(new DeathEvent(evt.Target));
                }
            }
        }
    }

    public struct DeathEvent
    {
        public readonly HeroEntity target;

        public DeathEvent(HeroEntity target)
        {
            this.target = target;
        }
    }
}