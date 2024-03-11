namespace Core.Events
{
    public struct PreAttackEvent
    {
        public IHeroListenable Target;
        public IHeroListenable Source;

        public PreAttackEvent(IHeroListenable source, IHeroListenable target)
        {
            Target = target;
            Source = source;
        }
    }
}