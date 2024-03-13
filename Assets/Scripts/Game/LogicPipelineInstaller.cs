using Core.Pipeline;
using Core.Tasks.Logic;
using VContainer;
using VContainer.Unity;

namespace Game
{
    public sealed class LogicPipelineInstaller: IInitializable
    {
        private readonly LogicPipeline _pipeline;
        private readonly IObjectResolver _objectResolver;

        public LogicPipelineInstaller(LogicPipeline pipeline, IObjectResolver objectResolver)
        {
            _pipeline = pipeline;
            _objectResolver = objectResolver;
        }

        void IInitializable.Initialize()
        {
            _pipeline.AddTask(_objectResolver.Resolve<StartTurnTask>());
            _pipeline.AddTask(_objectResolver.Resolve<VisualPipelineRunTask>());
            _pipeline.AddTask(_objectResolver.Resolve<PlayerTask>());
            _pipeline.AddTask(_objectResolver.Resolve<EndTurnAbilityTask>());
            _pipeline.AddTask(_objectResolver.Resolve<EndTurnGeneralAbilityTask>());
            _pipeline.AddTask(_objectResolver.Resolve<EndTurnTask>());
            _pipeline.AddTask(_objectResolver.Resolve<VisualPipelineRunTask>());
            _pipeline.AddTask(_objectResolver.Resolve<SwitchPlayerTask>());
            _pipeline.AddTask(_objectResolver.Resolve<FinishGameTask>());
        }
    }
}