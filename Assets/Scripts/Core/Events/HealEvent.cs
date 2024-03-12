namespace Core.Handlers
{
    public struct HealEvent
    {
        public readonly HeroEntity target;
        public readonly int hp;

        public HealEvent(HeroEntity target, int hp)
        {
            this.target = target;
            this.hp = hp;
        }
    }
}