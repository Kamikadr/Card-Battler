using Core.Effects.EndTurnGeneral;
using Core.Pipeline;
using Core.Tasks.Visual.Effects;

namespace Core.Handlers.Visual.Effects
{
    public sealed class EndTurnRandomHealEffectVisualHandler:BaseVisualHandler<EndTurnRandomHealEffect>
    {
        public EndTurnRandomHealEffectVisualHandler(EventBus.EventBus eventBus, VisualPipeline visualPipeline) : base(eventBus, visualPipeline)
        {
        }

        protected override void OnEventHandle(EndTurnRandomHealEffect evt)
        {
            _visualPipeline.AddTask(new EndTurnRandomHealEffectVisualTask(evt.Source));
        }
    }
}