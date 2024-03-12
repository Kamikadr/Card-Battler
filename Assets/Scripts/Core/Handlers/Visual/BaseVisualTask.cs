using Core.Pipeline;

namespace Core.Handlers.Visual
{
    public abstract class BaseVisualTask<T>: BaseHandler<T>
    {
        protected VisualPipeline _visualPipeline;
        protected BaseVisualTask(EventBus eventBus, VisualPipeline visualPipeline) : base(eventBus)
        {
            _visualPipeline = visualPipeline;
        }
    }
}