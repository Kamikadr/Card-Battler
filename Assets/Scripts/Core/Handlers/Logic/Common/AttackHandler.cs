using System.Linq;
using Core.Effects.Attack;
using Core.Events;

namespace Core.Handlers.Logic.Common
{
    public sealed class AttackHandler: BaseHandler<AttackEvent>
    {
        public AttackHandler(EventBus.EventBus eventBus) : base(eventBus)
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