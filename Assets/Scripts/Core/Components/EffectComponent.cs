using System;
using System.Collections.Generic;

namespace Core.Components
{
    public class EffectComponent
    {
        private Dictionary<Type, List<IEffect>> _effectCollection;

        public void Add<T>(T effect) where T: IEffect
        {
            _effectCollection.TryAdd(typeof(T), new List<IEffect>());
            _effectCollection[typeof(T)].Add(effect);
        }

        public IEnumerable<T> GetEffects<T>() where T : IEffect
        {
            if (_effectCollection.TryGetValue(typeof(T), out var value))
            {
                for (var i = 0; i < value.Count; i++)
                {
                    if (value[i] is T concreteEffect)
                    {
                        yield return concreteEffect;
                    }
                }
            }
        }
    }

    public interface IEffect
    {
        
    }
}