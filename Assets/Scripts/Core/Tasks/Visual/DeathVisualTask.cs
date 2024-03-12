using Cysharp.Threading.Tasks;

namespace Core.Tasks.Visual
{
    public class DeathVisualTask: BaseVisualTask
    {
        public DeathVisualTask(HeroEntity source) : base(source)
        {
        }
        
        protected override UniTask OnRun()
        {
            return UniTask.CompletedTask;
        }

        
    }
}