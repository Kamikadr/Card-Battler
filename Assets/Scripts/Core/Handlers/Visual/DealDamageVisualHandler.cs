using Core.Events;
using Core.Pipeline;
using Core.Tasks.Visual;

namespace Core.Handlers.Visual
{
    public class DealDamageVisualHandler: BaseVisualHandler<DealDamageEvent>
    {
        public DealDamageVisualHandler(EventBus eventBus, VisualPipeline visualPipeline) : base(eventBus, visualPipeline)
        {
        }

        protected override void OnEventHandle(DealDamageEvent evt)
        {
            _visualPipeline.AddTask(new DealDamageVisualTask(evt.Target));
        }
    }
}