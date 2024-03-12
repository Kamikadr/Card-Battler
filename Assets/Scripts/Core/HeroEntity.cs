using System;
using System.Collections.Generic;
using System.Linq;
using Core.Components;
using Core.Effects;
using UnityEngine;

namespace Core
{
    public abstract class HeroEntity: MonoBehaviour
    {
        private Dictionary<Type, object> _componentCollection = new();
        private readonly Dictionary<Type, List<BaseEffect>> _effectCollection = new();


        

        public void AddComponent<T>(T component) where T: IComponent
        {
            _componentCollection[typeof(T)] = component;
        }

        public T GetEntityComponent<T>()
        {
            return (T) _componentCollection[typeof(T)];
        }

        public void AddEffect<T>(T effect) where T: BaseEffect
        {
            if (!_effectCollection.TryGetValue(typeof(T), out var value))
            {
                value = new List<BaseEffect>();
                _effectCollection.Add(typeof(T), value);
            }
            value.Add(effect);
        }
        public IEnumerable<T> GetEffects<T>() where T: BaseEffect
        {
            if (_effectCollection.TryGetValue(typeof(T), out var value))
            {
                return value.Cast<T>();
            }
            return Enumerable.Empty<T>();
        }
        public bool TryGetEffects<T>(out IEnumerable<T> value) where T: BaseEffect
        {
            if (_effectCollection.TryGetValue(typeof(T), out var list))
            {
                value = list.Cast<T>();
                return true;
            }

            value = default;
            return false;
        }

        public void ClearEntity()
        {
            _componentCollection.Clear();
            _effectCollection.Clear();
        }
        
        public void Dispose()
        {
            _componentCollection.Clear();
            _componentCollection = null;
        }
    }
}
