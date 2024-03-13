using Core.Pipeline;
using Core.Tasks.Visual;

namespace Core.Handlers.Visual
{
    public class HealVisualHandler: BaseVisualHandler<HealEvent>
    {
        public HealVisualHandler(EventBus eventBus, VisualPipeline visualPipeline) : base(eventBus, visualPipeline)
        {
        }

        protected override void OnEventHandle(HealEvent evt)
        {
            _visualPipeline.AddTask(new HealVisualTask(evt.target));
        }
    }
}