using System;

namespace Core.EventBus
{
    public interface IEventHandlerCollection
    {
        public void Subscribe(Delegate handler);
        public void Unsubscribe(Delegate handler);
        public void RaiseEvent<T>(T evt);
    }
}