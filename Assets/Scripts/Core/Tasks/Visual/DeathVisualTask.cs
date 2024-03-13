using Cysharp.Threading.Tasks;

namespace Core.Tasks.Visual
{
    public sealed class DeathVisualTask: BaseVisualTask
    {
        public DeathVisualTask(HeroEntity source) : base(source)
        {
        }
        
        protected override async UniTask OnRun()
        {
            var audio = Source.GetEntityComponent<HeroAudioComponent>();
            await AudioPlayer.Instance.PlaySoundAsync(audio.GetDeathAudio());
            Finish();
        }

        
    }
}