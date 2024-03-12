namespace Core.Pipeline
{
    public sealed class LogicPipelineRunner
    {
        private readonly LogicPipeline _pipeline;
        private bool _autoRun;
        private bool _isRunning;

        public LogicPipelineRunner(LogicPipeline pipeline)
        {
            _pipeline = pipeline;
        }

        public void Run(bool autoRun)
        {
            if (_isRunning)
            {
                return;
            }
            _autoRun = autoRun;
            _pipeline.OnFinished += OnPipelineFinished;
            Run();
        }

        private void Run()
        {
            _pipeline.Run();
        }

        private void OnPipelineFinished()
        {
            if (_autoRun)
            {
                Run();
            }
            else
            {
                _pipeline.OnFinished -= OnPipelineFinished;
                _isRunning = false;
            }
        }
    }
}