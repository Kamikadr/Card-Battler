namespace Core.Events
{
    public struct BackAttackEvent
    {
        public IHeroListenable Target;
        public IHeroListenable Source;

        public BackAttackEvent(IHeroListenable source, IHeroListenable target)
        {
            Target = target;
            Source = source;
        }
    }
}