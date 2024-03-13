using Cysharp.Threading.Tasks;

namespace Core.Tasks.Visual
{
    public sealed class HeroActivityVisualTask: BaseVisualTask
    {
        private readonly bool _isActive;

        public HeroActivityVisualTask(HeroEntity target, bool isActive): base(target)
        {
            _isActive = isActive;
        }

        protected override async UniTask OnRun()
        {
            SourceView.Value.SetActive(_isActive);
            
            if (_isActive)
            {
                var audio = Source.GetEntityComponent<HeroAudioComponent>();
                await AudioPlayer.Instance.PlaySoundAsync(audio.GetStartAudio());
            }
            
            Finish();
        }
    }
}