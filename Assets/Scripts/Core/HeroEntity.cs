using System;
using System.Collections.Generic;

namespace Core
{
    public class HeroEntity: IDisposable
    {
        private Dictionary<Type, object> componentCollection = new();

        public void Initialize()
        {
            
        }
    
        public void AddComponent()
        {
        
        }

        public object GetComponent<T>()
        {
            return componentCollection[typeof(T)];
        }

        public void Dispose()
        {
            componentCollection.Clear();
            componentCollection = null;
        }
    }
}
