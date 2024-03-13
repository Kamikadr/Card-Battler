using Core.Pipeline;

namespace Core.Handlers.Visual
{
    public abstract class BaseVisualHandler<T>: BaseHandler<T>
    {
        protected VisualPipeline _visualPipeline;
        protected BaseVisualHandler(EventBus.EventBus eventBus, VisualPipeline visualPipeline) : base(eventBus)
        {
            _visualPipeline = visualPipeline;
        }
    }
}