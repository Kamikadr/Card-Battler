using UI;

namespace Core.Events
{
    public struct DealDamageEvent
    {
        public IHeroListenable Target;
        public int Damage;

        public DealDamageEvent(int damage, IHeroListenable target)
        {
            Damage = damage;
            Target = target;
        }
    }
}