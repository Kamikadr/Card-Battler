using Core.Effects;

namespace Core.Heroes
{
    public class PaladinEntity:BaseHeroEntity
    {
        protected override void OnInitialize()
        {
            AddEffect<DamageEvasionEffect>(new DamageAbsorptionEffect(1, this));
        }
    }
}