namespace Core.Events
{
    public struct DeathEvent: IEvent
    {
        public readonly HeroEntity Target;

        public DeathEvent(HeroEntity target)
        {
            Target = target;
        }
    }
}