using Core.Effects.PreAttack;
using Core.Events;

namespace Core.Handlers
{
    public class PreAttackHandler: BaseHandler<PreAttackEvent>
    {
        public PreAttackHandler(EventBus eventBus) : base(eventBus)
        {
        }

        protected override void OnEventHandle(PreAttackEvent evt)
        {
            
        }
    }
}