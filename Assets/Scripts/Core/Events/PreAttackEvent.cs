namespace Core.Events
{
    public struct PreAttackEvent: IEvent
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