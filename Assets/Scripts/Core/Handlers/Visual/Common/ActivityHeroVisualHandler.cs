using Core.Events;
using Core.Pipeline;
using Core.Tasks.Visual;

namespace Core.Handlers.Visual.Common
{
    public sealed class ActivityHeroVisualHandler: BaseVisualHandler<ActivityHeroEvent>
    {
        public ActivityHeroVisualHandler(EventBus.EventBus eventBus, VisualPipeline visualPipeline) : base(eventBus, visualPipeline)
        {
        }

        protected override void OnEventHandle(ActivityHeroEvent evt)
        {
            _visualPipeline.AddTask(new HeroActivityVisualTask(evt.Hero, evt.IsActive));
        }
    }
}