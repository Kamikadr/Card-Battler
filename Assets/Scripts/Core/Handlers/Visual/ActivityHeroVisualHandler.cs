using Core.Events;
using Core.Pipeline;
using Core.Tasks.Visual;

namespace Core.Handlers.Visual
{
    public class ActivityHeroVisualHandler: BaseVisualHandler<ActivityHeroEvent>
    {
        public ActivityHeroVisualHandler(EventBus eventBus, VisualPipeline visualPipeline) : base(eventBus, visualPipeline)
        {
        }

        protected override void OnEventHandle(ActivityHeroEvent evt)
        {
            _visualPipeline.AddTask(new HeroActivityVisualTask(evt.hero, evt.isActive));
        }
    }
}