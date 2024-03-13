using System;
using System.Linq;
using Core.Components;
using Core.Effects.TakeDamage;
using Core.Events;

namespace Core.Handlers.Logic.Common
{
    public sealed class DealDamageHandler: BaseHandler<DealDamageEvent>
    {
        public DealDamageHandler(EventBus.EventBus eventBus) : base(eventBus)
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
                health.CurrentHealth = (int) MathF.Max(0, health.CurrentHealth - evt.Damage);

                var effects = evt.Target.GetEffects<TakeDamageEffect>();
                foreach (var effect in effects.ToArray())
                {
                    EventBus.RaiseEvent(effect);
                }
                
                if (health.CurrentHealth <= 0)
                {
                    EventBus.RaiseEvent(new DeathEvent(evt.Target));
                }
            }
        }
    }
}