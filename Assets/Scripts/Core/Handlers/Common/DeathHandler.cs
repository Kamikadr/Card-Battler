using Core.Components;
using Core.Effects;
using Core.Events;

namespace Core.Handlers
{
    public class DeathHandler: BaseHandler<DeathEvent>
    {
        public DeathHandler(EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(DeathEvent evt)
        {
            evt.target.AddEffect(new ImmovableEffect(evt.target));
            evt.target.AddEffect(new UntouchableEffect(evt.target));
        }
    }
}