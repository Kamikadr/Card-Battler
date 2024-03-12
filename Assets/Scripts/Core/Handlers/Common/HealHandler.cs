using System;

namespace Core.Handlers
{
    public class HealHandler: BaseHandler<HealEvent>
    {
        public HealHandler(EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(HealEvent evt)
        {
            var healthComponent = evt.target.GetEntityComponent<HealthComponent>();
            healthComponent.currentHealth =
                (int)MathF.Min(healthComponent.currentHealth + evt.hp, healthComponent.maxHealth);
        }
    }
}