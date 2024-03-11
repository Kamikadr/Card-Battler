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
}