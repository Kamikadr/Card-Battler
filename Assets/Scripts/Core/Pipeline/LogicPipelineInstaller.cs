using Core.Tasks;

namespace Core.Pipeline
{
    public class LogicPipelineInstaller
    {
        private readonly LogicPipeline _pipeline;
        
        public LogicPipelineInstaller(LogicPipeline pipeline)
        {
            _pipeline = pipeline;
        }

        public void Install()
        {
            _pipeline.AddTask(new StartTurnTask());
            _pipeline.AddTask(new PlayerTask());
            _pipeline.AddTask(new EndTurnTask());
            _pipeline.AddTask(new SwitchPlayerTask());
            _pipeline.AddTask(new FinishGameTask());
        }
    }
}