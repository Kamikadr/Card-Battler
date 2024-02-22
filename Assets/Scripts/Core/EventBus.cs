using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBus
{
   private Dictionary<Type, IEventHandlerCollection> _handlers = new();
   private int _currentIndex = 0;


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

   public void RaiseEvent<T>(T evt)
   {
      var eventType = typeof(T);
      if (_handlers.TryGetValue(eventType, out var handlerCollection))
      {
         handlerCollection.RaiseEvent(evt);
      }
   }
}