namespace Core.Pipeline
{
    public sealed class LogicPipelineRunner
    {
        private readonly LogicPipeline _pipeline;

        public LogicPipelineRunner(LogicPipeline pipeline)
        {
            _pipeline = pipeline;
        }

        public void Run()
        {
            _pipeline.Run();
        }
    }
}