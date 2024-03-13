namespace Core.Effects.TakeDamage
{
    public class MassAttackEffect: TakeDamageEffect
    {
        public readonly int damage;

        public MassAttackEffect(HeroEntity source, int damage) : base(source)
        {
            this.damage = damage;
        }
    }
}