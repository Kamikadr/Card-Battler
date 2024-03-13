using Core.Components;
using Core.Effects;
using Core.Events;

namespace Core.Handlers.Logic.Common
{
    public sealed class DeathHandler: BaseHandler<DeathEvent>
    {
        public DeathHandler(EventBus.EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(DeathEvent evt)
        {
            evt.Target.AddEffect(new ImmovableEffect(evt.Target));
            evt.Target.AddEffect(new UntouchableEffect(evt.Target));
            evt.Target.AddEntityComponent(new DeathComponent());
        }
    }
}