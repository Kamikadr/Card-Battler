using Cysharp.Threading.Tasks;

namespace Core.Tasks.Visual.Effects
{
    public sealed class MassAttackEffectVisualTask: BaseVisualTask
    {
        public MassAttackEffectVisualTask(HeroEntity source) : base(source)
        {
        }

        protected override async UniTask OnRun()
        {
            var audio = Source.GetEntityComponent<HeroAudioComponent>();
            await AudioPlayer.Instance.PlaySoundAsync(audio.GetAbilityAudio());
            Finish();
        }
    }
}