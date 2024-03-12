using Core.Components;
using Core.Handlers;
using UnityEngine;
using Core.Effects.EndTurnEffect;

namespace Core.Heroes
{
    public class DevourerEntity: BaseHeroEntity
    {
 
        [SerializeField] private int abilityDamage;
        protected override void OnInitialize()
        {
            AddEffect<EndTurnEffect>(new DealDamageToRandomTargetEffect(abilityDamage, this));
        }
    }
}