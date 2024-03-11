namespace Core
{
    public interface IPlayerListenable
    {
        CharacterEntityContainer EnemyHeroList { get; }
        CharacterEntityContainer FriendHeroList { get; }
    }
}