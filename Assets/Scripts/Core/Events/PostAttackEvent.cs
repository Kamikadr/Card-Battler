namespace Core.Events
{
    public struct PostAttackEvent
    {
        public IHeroListenable Target;
        public IHeroListenable Source;

        public PostAttackEvent(IHeroListenable source, IHeroListenable target)
        {
            Target = target;
            Source = source;
        }
    }
}