using System;
using Cysharp.Threading.Tasks;

namespace Core.Tasks
{
    public abstract class BaseTask
    {
        private event Action Callback;

        public async UniTaskVoid Run(Action callback = default)
        {
            Callback = callback;
            await OnRun();
        }

        protected abstract UniTask OnRun();

        protected void Finish()
        {
            Callback?.Invoke();
            OnFinished();
        }

        protected virtual void OnFinished()
        {
        }
        
        
    }
}