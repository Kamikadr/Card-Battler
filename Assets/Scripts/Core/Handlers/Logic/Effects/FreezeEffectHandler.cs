using Core.Effects;
using Core.Effects.Attack;

namespace Core.Handlers.Logic.Effects
{
    public sealed class FreezeEffectHandler: BaseHandler<FreezeEffect>
    {
        public FreezeEffectHandler(EventBus.EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(FreezeEffect evt)
        {
            evt.Target.AddEffect(new ImmovableEffect(evt.Target, evt.FreezeDuration));
        }
    }
}