using UI;

namespace Core.Tasks.Visual
{
    public abstract class BaseVisualTask: BaseTask
    {
        protected readonly HeroEntity source;
        protected readonly HeroViewComponent sourceView;

        protected BaseVisualTask(HeroEntity source)
        {
            this.source = source;
            sourceView = this.source.GetEntityComponent<HeroViewComponent>();
        }
    }
}