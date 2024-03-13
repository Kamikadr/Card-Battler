namespace Core.Effects.EndTurnEffect
{
    public sealed class DealDamageToRandomTargetEffect: EndTurnEffect
    {
        public int Damage { get; }

        public DealDamageToRandomTargetEffect(int damage, HeroEntity source): base(source)
        {
            Damage = damage;
        }
    }
}