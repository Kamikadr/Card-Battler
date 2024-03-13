using Core.Effects;

namespace Core.Handlers.Effects
{
    public class ImmovableEffectHandler: BaseHandler<ImmovableEffect>
    {
        public ImmovableEffectHandler(EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(ImmovableEffect evt)
        {
            if (evt.duration == 1)
            {
                evt.source.RemoveEffect<ImmovableEffect>(evt);
            }

            evt.duration--;
        }
    }
}