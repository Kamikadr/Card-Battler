using System;
using System.Collections;
using System.Collections.Generic;
using UI;

namespace Core
{
    public class PlayerContainer: IPlayerChangeable
    {
        public CharacterEntityContainer EnemyHeroList { get; private set; }
        public CharacterEntityContainer FriendHeroList { get; private set; }
        public void SwitchPlayers()
        {
            (EnemyHeroList, FriendHeroList) = (FriendHeroList, EnemyHeroList);
        }

        public PlayerContainer(CharacterEntityContainer enemyHeroList, CharacterEntityContainer friendHeroList)
        {
            EnemyHeroList = enemyHeroList;
            FriendHeroList = friendHeroList;
        }
    }

    public interface IPlayerListenable
    {
        CharacterEntityContainer EnemyHeroList { get; }
        CharacterEntityContainer FriendHeroList { get; }
    }
    public interface IPlayerChangeable: IPlayerListenable
    {
        void SwitchPlayers();
    }

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
    }
}