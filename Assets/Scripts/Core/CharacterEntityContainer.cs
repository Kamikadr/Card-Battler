using System;
using System.Collections.Generic;

namespace Core
{
    public class CharacterEntityContainer
    {
        private int _currentIndex;
        private readonly BaseHeroEntity[] _heroEntities;

        public CharacterEntityContainer(BaseHeroEntity[] heroEntities)
        {
            _heroEntities = heroEntities;
        }

        public BaseHeroEntity GetNext()
        {
            _currentIndex %= _heroEntities.Length;
            return _heroEntities[_currentIndex++];
        }

        public BaseHeroEntity GetByIndex(int index)
        {
            if (index < 0 || index >= _heroEntities.Length)
            {
                throw new Exception("Index is out of range");
            }

            return _heroEntities[index];
        }

        public int GetCount()
        {
            return _heroEntities.Length;
        }

        public IReadOnlyList<BaseHeroEntity> GetAll()
        {
            return _heroEntities;
        }
    }
}