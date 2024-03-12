using Cysharp.Threading.Tasks;

namespace Core.Tasks.Visual
{
    public class AttackVisualTask: BaseTask
    {
        private readonly HeroEntity _source;
        private readonly HeroEntity _target;

        public AttackVisualTask(HeroEntity source, HeroEntity target)
        {
            _source = source;
            _target = target;
        }

        protected override async UniTask OnRun()
        {
            var sourceView = _source.GetEntityComponent<HeroViewComponent>();
            var targetView = _target.GetEntityComponent<HeroViewComponent>();
            await sourceView.Value.AnimateAttack(targetView.Value);
            Finish();
        }
    }
}