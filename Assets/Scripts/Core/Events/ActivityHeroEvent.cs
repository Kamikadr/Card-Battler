namespace Core.Events
{
    public struct ActivityHeroEvent: IEvent
    {
        public readonly HeroEntity Hero;
        public readonly bool IsActive;

        public ActivityHeroEvent(HeroEntity hero, bool isActive)
        {
            Hero = hero;
            IsActive = isActive;
        }
    }
}