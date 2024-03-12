using Core.Effects.TakeDamage;

namespace Core.Effects
{
    public class DamageAbsorptionEffect: DamageEvasionEffect
    {
        public int duration;

        public DamageAbsorptionEffect(int duration, HeroEntity source): base(source)
        {
            this.duration = duration;
        }
    }
}