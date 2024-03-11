using System;

namespace Core
{
    public class CharacterEntityContainer
    {
        private int _currentIndex;
        private readonly HeroEntity[] _heroEntities;

        public CharacterEntityContainer(HeroEntity[] heroEntities)
        {
            _heroEntities = heroEntities;
        }

        public HeroEntity GetNext()
        {
            _currentIndex %= _heroEntities.Length;
            return _heroEntities[_currentIndex++];
        }

        public HeroEntity GetByIndex(int index)
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
    }
}