using Cysharp.Threading.Tasks;

namespace Core.Tasks.Visual
{
    public class DeathVisualTask: BaseVisualTask
    {
        public DeathVisualTask(HeroEntity source) : base(source)
        {
        }
        
        protected override async UniTask OnRun()
        {
            var audio = source.GetEntityComponent<HeroAudioComponent>();
            await AudioPlayer.Instance.PlaySoundAsync(audio.GetDeathAudio());
            Finish();
        }

        
    }
}