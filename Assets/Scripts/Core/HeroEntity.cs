using System;
using System.Collections.Generic;
using System.Linq;
using Core.Effects;
using UnityEngine;

namespace Core
{
    public class HeroEntity: MonoBehaviour
    {
        private Dictionary<Type, object> componentCollection = new();
        private Dictionary<Type, List<BaseEffect>> effectCollection = new();

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

        public void AddEffect<T>(T effect) where T: BaseEffect
        {
            if (!effectCollection.TryGetValue(typeof(T), out var value))
            {
                value = new List<BaseEffect>();
                effectCollection.Add(typeof(T), value);
            }
            value.Add(effect);
        }
        public IEnumerable<T> GetEffects<T>() where T: BaseEffect
        {
            if (effectCollection.TryGetValue(typeof(T), out var value))
            {
                return value.Cast<T>();
            }
            return Enumerable.Empty<T>();
        }
        public bool TryGetEffects<T>(out IEnumerable<T> value) where T: BaseEffect
        {
            if (effectCollection.TryGetValue(typeof(T), out var list))
            {
                value = list.Cast<T>();
                return true;
            }

            value = default;
            return false;
        }

        public void Dispose()
        {
            componentCollection.Clear();
            componentCollection = null;
        }
    }
}
