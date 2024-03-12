using UI;

namespace Core.Events
{
    public struct ActivityHeroEvent
    {
        public readonly HeroEntity hero;
        public readonly bool isActive;

        public ActivityHeroEvent(HeroEntity hero, bool isActive)
        {
            this.hero = hero;
            this.isActive = isActive;
        }
    }
}