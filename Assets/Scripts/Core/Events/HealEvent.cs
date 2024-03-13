namespace Core.Events
{
    public struct HealEvent: IEvent
    {
        public readonly HeroEntity Target;
        public readonly int Hp;

        public HealEvent(HeroEntity target, int hp)
        {
            Target = target;
            Hp = hp;
        }
    }
}