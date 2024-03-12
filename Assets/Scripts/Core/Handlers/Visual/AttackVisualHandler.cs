using Core.Events;
using Core.Pipeline;
using Core.Tasks.Visual;

namespace Core.Handlers.Visual
{
    public class AttackVisualHandler: BaseVisualHandler<AttackEvent>
    {
        public AttackVisualHandler(EventBus eventBus, VisualPipeline visualPipeline) : base(eventBus, visualPipeline)
        {
        }

        protected override void OnEventHandle(AttackEvent evt)
        {
            _visualPipeline.AddTask(new AttackVisualTask(evt.Source.Value, evt.Target.Value));
        }
    }
}