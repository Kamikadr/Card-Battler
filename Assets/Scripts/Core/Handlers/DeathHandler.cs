using Core.Components;

namespace Core.Handlers
{
    public class DeathHandler: BaseHandler<DeathEvent>
    {
        public DeathHandler(EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(DeathEvent evt)
        {
            evt.target.AddComponent(new DeathComponent());
        }
    }
}