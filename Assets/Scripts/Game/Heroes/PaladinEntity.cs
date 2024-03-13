using Core.Effects.TakeDamage;

namespace Game.Heroes
{
    public sealed class PaladinEntity:BaseHeroEntity
    {
        protected override void OnInitialize()
        {
            AddEffect<DamageEvasionEffect>(new DamageAbsorptionEffect(1, this));
        }
    }
}