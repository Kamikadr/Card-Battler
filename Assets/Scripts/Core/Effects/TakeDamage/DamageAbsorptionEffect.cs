namespace Core.Effects.TakeDamage
{
    public sealed class DamageAbsorptionEffect: DamageEvasionEffect
    {
        public int Duration;

        public DamageAbsorptionEffect(int duration, HeroEntity source): base(source)
        {
            this.Duration = duration;
        }
    }
}