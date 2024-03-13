using Core.Effects;

namespace Core.Handlers.Logic.Effects
{
    public sealed class ImmovableEffectHandler: BaseHandler<ImmovableEffect>
    {
        public ImmovableEffectHandler(EventBus.EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(ImmovableEffect evt)
        {
            if (evt.Duration == 1)
            {
                evt.Source.RemoveEffect<ImmovableEffect>(evt);
            }

            evt.Duration--;
        }
    }
}