namespace Core.Effects.TakeDamage
{
    public sealed class MassAttackEffect: TakeDamageEffect
    {
        public readonly int Damage;

        public MassAttackEffect(HeroEntity source, int damage) : base(source)
        {
            Damage = damage;
        }
    }
}