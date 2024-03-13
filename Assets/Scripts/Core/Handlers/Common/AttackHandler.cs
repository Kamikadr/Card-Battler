using System.Linq;
using Core.Components;
using Core.Effects;
using Core.Events;
using Core.Heroes;

namespace Core.Handlers
{
    public class AttackHandler: BaseHandler<AttackEvent>
    {
        public AttackHandler(EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(AttackEvent evt)
        {
            var attackEffects = evt.Source.Value.GetEffects<AttackEffect>();
            foreach (var effect in attackEffects.ToArray())
            {
                effect.Target = evt.Target.Value;
                EventBus.RaiseEvent(effect);
            }
        }
    }
}