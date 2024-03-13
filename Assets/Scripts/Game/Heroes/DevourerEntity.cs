using Core.Effects.EndTurnEffect;
using UnityEngine;

namespace Game.Heroes
{
    public sealed class DevourerEntity: BaseHeroEntity
    {
 
        [SerializeField] private int abilityDamage;
        protected override void OnInitialize()
        {
            AddEffect<EndTurnEffect>(new DealDamageToRandomTargetEffect(abilityDamage, this));
        }
    }
}