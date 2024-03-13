using Cysharp.Threading.Tasks;

namespace Core.Tasks.Visual.Effects
{
    public class MassAttackEffectVisualTask: BaseVisualTask
    {
        public MassAttackEffectVisualTask(HeroEntity source) : base(source)
        {
        }

        protected override async UniTask OnRun()
        {
            var audio = source.GetEntityComponent<HeroAudioComponent>();
            await AudioPlayer.Instance.PlaySoundAsync(audio.GetAbilityAudio());
            Finish();
        }
    }
}