using Core.DataContainers;
using Cysharp.Threading.Tasks;

namespace Core.Tasks.Logic
{
    public sealed class SwitchPlayerTask: BaseTask
    {
        private readonly IPlayerChangeable _playerContainer;

        public SwitchPlayerTask(IPlayerChangeable playerContainer)
        {
            _playerContainer = playerContainer;
        }

        protected override UniTask OnRun()
        {
            _playerContainer.SwitchPlayers();
            Finish();
            return UniTask.CompletedTask;
        }
    }
}