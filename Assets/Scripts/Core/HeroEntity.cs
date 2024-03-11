using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class HeroEntity: MonoBehaviour
    {
        private Dictionary<Type, object> componentCollection = new();

        public void Initialize()
        {
            
        }
    
        public void AddComponent()
        {
        
        }

        public T GetEntityComponent<T>()
        {
            return (T) componentCollection[typeof(T)];
        }

        public void Dispose()
        {
            componentCollection.Clear();
            componentCollection = null;
        }
    }
}
