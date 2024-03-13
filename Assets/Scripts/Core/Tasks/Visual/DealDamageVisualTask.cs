using Core.Components;
using Core.Handlers;
using Cysharp.Threading.Tasks;

namespace Core.Tasks.Visual
{
    public class DealDamageVisualTask: BaseTask
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
            
            heroView.Value.SetStats($"{damageComponent.Value} / {healthComponent.currentHealth}");
            if (healthComponent.currentHealth < healthComponent.maxHealth * 0.2)
            {
                var audio = _target.GetEntityComponent<HeroAudioComponent>();
                await AudioPlayer.Instance.PlaySoundAsync(audio.GetLowHealthAudio());
            }
            Finish();
        }
    }
}