namespace Core.Events
{
    public struct PreAttackEvent
    {
        public IHeroChangeable Target;
        public IHeroListenable Source;

        public PreAttackEvent(IHeroListenable source, IHeroChangeable target)
        {
            Target = target;
            Source = source;
        }
    }
}