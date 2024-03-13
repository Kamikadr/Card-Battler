using Core.Events;
using Core.Pipeline;
using Core.Tasks.Visual;

namespace Core.Handlers.Visual.Common
{
    public sealed class HealVisualHandler: BaseVisualHandler<HealEvent>
    {
        public HealVisualHandler(EventBus.EventBus eventBus, VisualPipeline visualPipeline) : base(eventBus, visualPipeline)
        {
        }

        protected override void OnEventHandle(HealEvent evt)
        {
            _visualPipeline.AddTask(new HealVisualTask(evt.Target));
        }
    }
}