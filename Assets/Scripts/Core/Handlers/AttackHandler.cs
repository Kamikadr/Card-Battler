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
            throw new System.NotImplementedException();
        }
    }
}