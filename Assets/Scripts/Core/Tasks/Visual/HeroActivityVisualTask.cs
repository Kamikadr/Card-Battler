using Cysharp.Threading.Tasks;

namespace Core.Tasks.Visual
{
    public class HeroActivityVisualTask: BaseVisualTask
    {
        private readonly bool _isActive;

        public HeroActivityVisualTask(HeroEntity target, bool isActive): base(target)
        {
            _isActive = isActive;
        }

        protected override async UniTask OnRun()
        {
            sourceView.Value.SetActive(_isActive);
            
            if (_isActive)
            {
                var audio = source.GetEntityComponent<HeroAudioComponent>();
                await AudioPlayer.Instance.PlaySoundAsync(audio.GetStartAudio());
            }
            
            Finish();
        }
    }
}