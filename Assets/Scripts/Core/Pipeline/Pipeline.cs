using System;
using System.Collections.Generic;
using Core.Tasks;
using Unity.VisualScripting;

namespace Core.Pipeline
{
    public class Pipeline
    {
        public event Action OnFinished;  

        private readonly List<BaseTask> _tasks = new();
        private int _currentIndex;

        public void AddTask(BaseTask task)
        {
            _tasks.Add(task);
        }

        public void Run()
        {
            _currentIndex = 0;
            RunNext();
        }

        public void Clear()
        {
            _tasks.Clear();
        }

        private void RunNext()
        {
            if (_currentIndex >= _tasks.Count)
            {
                OnFinished?.Invoke();
                return;
            }
            
            _tasks[_currentIndex].Run(OnTaskFinished);
        }
        private void OnTaskFinished()
        {
            _currentIndex++;
            RunNext();
        }
    }
}