using System;
using VContainer.Unity;

namespace Core.Handlers
{
    public abstract class BaseHandler<T>:IInitializable, IDisposable
    {
        protected readonly EventBus.EventBus EventBus;

        protected BaseHandler(EventBus.EventBus eventBus)
        {
            EventBus = eventBus;
        }
        void IInitializable.Initialize()
        {
            EventBus.Subscribe<T>(OnEventHandle);
        }
        protected abstract void OnEventHandle(T evt);

        void IDisposable.Dispose()
        {
            EventBus.Unsubscribe<T>(OnEventHandle);
        }

        
    }
}