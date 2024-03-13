using System;
using Core.Pipeline;
using VContainer.Unity;

namespace Core
{
    public class ResultController: IInitializable, IDisposable
    {
        private readonly IResultChecker _resultChecker;
        private readonly LogicPipelineRunner _logicPipelineRunner;

        public ResultController(IResultChecker resultChecker, LogicPipelineRunner logicPipelineRunner)
        {
            _resultChecker = resultChecker;
            _logicPipelineRunner = logicPipelineRunner;
            
        }

        void IInitializable.Initialize()
        {
            _resultChecker.OnResultReceived += StopPipeline;
        }
        private void StopPipeline()
        {
            _logicPipelineRunner.StopRun();
        }

        void IDisposable.Dispose()
        {
            _resultChecker.OnResultReceived -= StopPipeline;
        }
    }
}