using UI;

namespace Core
{
    public class HeroContainer: IPlayerChangeable
    {
        public HeroListView EnemyHeroList { get; set; }
        public HeroListView FriendHeroList { get; set; }

        public HeroContainer(HeroListView enemyHeroList, HeroListView friendHeroList)
        {
            EnemyHeroList = enemyHeroList;
            FriendHeroList = friendHeroList;
        }
    }

    public interface IPlayerListenable
    {
        HeroListView EnemyHeroList { get; }
         HeroListView FriendHeroList { get; }
    }
    public interface IPlayerChangeable: IPlayerListenable
    {
        new HeroListView EnemyHeroList { get; set; }
        new HeroListView FriendHeroList { get; set; }
    }
}