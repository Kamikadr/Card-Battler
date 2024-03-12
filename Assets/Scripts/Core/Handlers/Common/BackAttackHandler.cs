using Core.Effects;
using Core.Events;

namespace Core.Handlers
{
    public class BackAttackHandler: BaseHandler<BackAttackEvent>
    {
        public BackAttackHandler(EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(BackAttackEvent evt)
        {
            if (evt.Target.Value.TryGetEffects<BackAttackEvade>(out var evasionEffects))
            {
                foreach (var effect in evasionEffects)
                {
                    EventBus.RaiseEvent(effect);
                }
            }
            else
            {
                EventBus.RaiseEvent(new AttackEvent(evt.Source, evt.Target));
            }
        }
    }
}