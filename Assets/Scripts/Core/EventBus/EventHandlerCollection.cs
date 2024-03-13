using System;
using System.Collections.Generic;

namespace Core.EventBus
{
    public sealed class EventHandlerCollection<T> : IEventHandlerCollection
    {
        private readonly List<Delegate> _handlers = new();
        private int _currentIndex;


        public void Subscribe(Delegate handler)
        {
            _handlers.Add(handler);
        }

        public void Unsubscribe(Delegate handler)
        {
            var index = _handlers.IndexOf(handler);
            _handlers.RemoveAt(index);
         
            if (index <= _currentIndex)
            {
                _currentIndex--;
            }
        }

        public void RaiseEvent<TEvent>(TEvent evt)
        {
            if (evt is not T concreteEvent)
            {
                return;
            }
         
            for (_currentIndex = 0; _currentIndex < _handlers.Count; _currentIndex++)
            {
                var handler = (Action<T>) _handlers[_currentIndex];
                handler.Invoke(concreteEvent);
            }

            _currentIndex = -1;
        }
    }
}