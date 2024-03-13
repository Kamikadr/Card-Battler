using Core.Events;
using Core.Pipeline;
using Core.Tasks.Visual;

namespace Core.Handlers.Visual
{
    public class DeathVisualHandler: BaseVisualHandler<DeathEvent>
    {
        public DeathVisualHandler(EventBus eventBus, VisualPipeline visualPipeline) : base(eventBus, visualPipeline)
        {
        }

        protected override void OnEventHandle(DeathEvent evt)
        {
            _visualPipeline.AddTask(new DeathVisualTask(evt.target));
        }
    }
}