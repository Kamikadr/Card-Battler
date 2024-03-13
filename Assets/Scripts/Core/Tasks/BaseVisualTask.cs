namespace Core.Tasks
{
    public abstract class BaseVisualTask: BaseTask
    {
        protected readonly HeroEntity Source;
        protected readonly HeroViewComponent SourceView;

        protected BaseVisualTask(HeroEntity source)
        {
            Source = source;
            SourceView = Source.GetEntityComponent<HeroViewComponent>();
        }
    }
}