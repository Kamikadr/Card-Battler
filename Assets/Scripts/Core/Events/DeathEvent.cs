namespace Core.Events
{
    public struct DeathEvent: IEvent
    {
        public readonly HeroEntity target;

        public DeathEvent(HeroEntity target)
        {
            this.target = target;
        }
    }
}