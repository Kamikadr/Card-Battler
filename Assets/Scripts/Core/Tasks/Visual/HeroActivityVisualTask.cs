using Cysharp.Threading.Tasks;

namespace Core.Tasks.Visual
{
    public class HeroActivityVisualTask: BaseTask
    {
        private readonly HeroEntity _target;
        private readonly bool _isActive;

        public HeroActivityVisualTask(HeroEntity target, bool isActive)
        {
            _target = target;
            _isActive = isActive;
        }

        protected override UniTask OnRun()
        {
            var view = _target.GetEntityComponent<HeroViewComponent>();
            view.Value.SetActive(_isActive);
            Finish();
            return UniTask.CompletedTask;
        }
    }
}