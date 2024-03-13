using Core.Components;
using Cysharp.Threading.Tasks;

namespace Core.Tasks.Visual
{
    public sealed class HealVisualTask: BaseTask
    {
        private readonly HeroEntity _target;

        public HealVisualTask(HeroEntity target)
        {
            _target = target;
        }

        protected override UniTask OnRun()
        {
            var healthComponent = _target.GetEntityComponent<HealthComponent>();
            var damageComponent = _target.GetEntityComponent<DamageComponent>();
            var heroView = _target.GetEntityComponent<HeroViewComponent>();
            
            heroView.Value.SetStats($"{damageComponent.Value} / {healthComponent.CurrentHealth}");
            Finish();
            return UniTask.CompletedTask;
        }
    }
}