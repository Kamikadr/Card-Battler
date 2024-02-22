using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public abstract class Entity: MonoBehaviour
    {
        private Dictionary<Type, object> _componentCollection = new();

        public void Add<T>(T component)
        {
            var componentType = component.GetType();
            _componentCollection.Add(componentType, component);
        }

        public T Get<T>() where T: class
        {
            if (!_componentCollection.TryGetValue(typeof(T), out var value))
            {
                throw new Exception("Value is not found");
            }
            
            if (value is T castedValue)
            {
                return castedValue;
            }
            throw new Exception($"Value is not {typeof(T)}");
        }
    }
}