namespace Core.DataContainers
{
    public sealed class HeroContainer: IHeroChangeable
    {
        public HeroEntity Value { get; set; }
    }

    public interface IHeroChangeable: IHeroListenable
    {
        new HeroEntity Value { get; set; }
    }

    public interface IHeroListenable
    {
        HeroEntity Value { get; }
    }
}