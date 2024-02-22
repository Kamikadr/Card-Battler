using System;

namespace Core.Handlers
{
    public abstract class BaseHandler<T>: IDisposable
    {
        protected readonly EventBus EventBus;

        protected BaseHandler(EventBus eventBus)
        {
            EventBus = eventBus;
            EventBus.Subscribe<T>(OnEventHandle);
        }

        protected abstract void OnEventHandle(T evt);

        public void Dispose()
        {
            EventBus.Unsubscribe<T>(OnEventHandle);
        }
    }
}