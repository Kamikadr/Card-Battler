using Core.Components;
using Core.Effects;

namespace Core.Handlers
{
    public class DeathHandler: BaseHandler<DeathEvent>
    {
        public DeathHandler(EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(DeathEvent evt)
        {
            evt.target.AddEffect(new ImmovableEffect());
            evt.target.AddEffect(new UntouchableEffect());
        }
    }
}