using Core.Components;
using Cysharp.Threading.Tasks;

namespace Core.Tasks.Visual
{
    public sealed class DealDamageVisualTask: BaseTask
    {
        private readonly HeroEntity _target;

        public DealDamageVisualTask(HeroEntity target)
        {
            _target = target;
        }

        protected async override UniTask OnRun()
        {
            var healthComponent = _target.GetEntityComponent<HealthComponent>();
            var damageComponent = _target.GetEntityComponent<DamageComponent>();
            var heroView = _target.GetEntityComponent<HeroViewComponent>();
            
            heroView.Value.SetStats($"{damageComponent.Value} / {healthComponent.CurrentHealth}");
            if (healthComponent.CurrentHealth < healthComponent.MaxHealth * 0.2)
            {
                var audio = _target.GetEntityComponent<HeroAudioComponent>();
                await AudioPlayer.Instance.PlaySoundAsync(audio.GetLowHealthAudio());
            }
            Finish();
        }
    }
}