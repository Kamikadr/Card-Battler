namespace Core.Events
{
    public struct DealDamageEvent: IEvent
    {
        public readonly HeroEntity Target;
        public readonly int Damage;

        public DealDamageEvent(int damage, HeroEntity target)
        {
            Damage = damage;
            Target = target;
        }
    }
}