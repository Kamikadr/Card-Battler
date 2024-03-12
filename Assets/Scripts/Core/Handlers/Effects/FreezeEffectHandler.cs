using Core.Effects;

namespace Core.Handlers.Effects
{
    public class FreezeEffectHandler: BaseHandler<FreezeEffect>
    {
        public FreezeEffectHandler(EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(FreezeEffect evt)
        {
            evt.Target.AddEffect(new ImmovableEffect(evt.Target, evt.freezeDuration));
        }
    }
}