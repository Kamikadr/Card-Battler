using UI;

namespace Core.Events
{
    public struct DealDamageEvent: IEvent
    {
        public HeroEntity Target;
        public int Damage;

        public DealDamageEvent(int damage, HeroEntity target)
        {
            Damage = damage;
            Target = target;
        }
    }
}