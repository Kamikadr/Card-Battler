using System;
using System.Collections.Generic;
using Core.Events;

namespace Core.EventBus
{
   public sealed class EventBus
   {
      private readonly Dictionary<Type, IEventHandlerCollection> _handlers = new();
      private bool _isRunning;
      private readonly Queue<IEvent> _eventQueue = new();


      public void Subscribe<T>(Action<T> handler)
      {
         var handlerType = typeof(T);
         _handlers.TryAdd(handlerType, new EventHandlerCollection<T>());

         _handlers[handlerType].Subscribe(handler);
      }

      public void Unsubscribe<T>(Action<T> handler)
      {
         var handlerType = typeof(T);
         if (_handlers.TryGetValue(handlerType, out var handlerCollection))
         {
            handlerCollection.Unsubscribe(handler);
         }
      }

      public void RaiseEvent<T>(T evt) where T: IEvent
      {
         if (_isRunning)
         {
            _eventQueue.Enqueue(evt);
            return;
         }

         _isRunning = true;
         var eventType = evt.GetType();
         if (_handlers.TryGetValue(eventType, out var handlerCollection))
         {
            handlerCollection.RaiseEvent(evt);
         }

         _isRunning = false;
         if (_eventQueue.TryDequeue(out var queueEvt))
         {
            RaiseEvent(queueEvt);
         }
      }
   }
}