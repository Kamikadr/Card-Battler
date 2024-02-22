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
            throw new System.NotImplementedException();
        }
    }
}