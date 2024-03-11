namespace Core.Tasks
{
    public class SwitchPlayerTask: BaseTask
    {
        private readonly IPlayerChangeable _playerContainer;

        public SwitchPlayerTask(IPlayerChangeable playerContainer)
        {
            _playerContainer = playerContainer;
        }

        protected override void OnRun()
        {
            _playerContainer.SwitchPlayers();
        }
    }
}