namespace Core.DataContainers
{
    public interface IPlayerListenable
    {
        CharacterEntityContainer EnemyHeroList { get; }
        CharacterEntityContainer FriendHeroList { get; }
    }
}