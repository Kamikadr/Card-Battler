using System;
using Core.Components;
using Core.Events;

namespace Core.Handlers.Logic.Common
{
    public sealed class HealHandler: BaseHandler<HealEvent>
    {
        public HealHandler(EventBus.EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(HealEvent evt)
        {
            var healthComponent = evt.Target.GetEntityComponent<HealthComponent>();
            healthComponent.CurrentHealth =
                (int)MathF.Min(healthComponent.CurrentHealth + evt.Hp, healthComponent.MaxHealth);
        }
    }
}