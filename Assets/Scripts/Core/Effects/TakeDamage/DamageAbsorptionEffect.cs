using Core.Effects.TakeDamage;

namespace Core.Effects
{
    public class DamageAbsorptionEffect: TakeDamageEffect
    {
        public int duration;

        public DamageAbsorptionEffect(int duration)
        {
            this.duration = duration;
        }
    }
}