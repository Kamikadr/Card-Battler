using Core.Pipeline;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Core.Tasks
{
    public class VisualPipelineRunTask: BaseTask
    {
        private readonly VisualPipeline _visualPipeline;

        public VisualPipelineRunTask(VisualPipeline visualPipeline)
        {
            _visualPipeline = visualPipeline;
        }

        protected override UniTask OnRun()
        {
            Debug.Log("Visual");
            _visualPipeline.OnFinished += OnVisualPipelineCompleted;
            _visualPipeline.Run();
            return UniTask.CompletedTask;
        }

        private void OnVisualPipelineCompleted()
        {
            _visualPipeline.OnFinished -= OnVisualPipelineCompleted;
            _visualPipeline.Clear();
            Finish();
        }
    }
}