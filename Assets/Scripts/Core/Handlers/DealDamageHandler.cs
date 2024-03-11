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
            var health = evt.Target.Value.GetEntityComponent<HealthComponent>();

            health.Value -= evt.Damage;
        }
    }
}