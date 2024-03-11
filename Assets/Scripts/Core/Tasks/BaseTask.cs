using System;

namespace Core.Tasks
{
    public abstract class BaseTask
    {
        private Action _callback;

        public void Run(Action callback = default)
        {
            _callback = callback;
            OnRun();
        }

        protected abstract void OnRun();
        
    }
}