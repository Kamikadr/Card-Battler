using Core.Events;

namespace Core.Handlers
{
    public class AttackHandler: BaseHandler<AttackEvent>
    {
        public AttackHandler(EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(AttackEvent evt)
        {
            EventBus.RaiseEvent(new PreAttackEvent(evt.Source, evt.Target));

            var damage = evt.Source.Value.GetEntityComponent<DamageComponent>();
            EventBus.RaiseEvent(new DealDamageEvent(damage.Value, evt.Target));
            
            EventBus.RaiseEvent(new PostAttackEvent(evt.Source, evt.Target));
        }
    }
}