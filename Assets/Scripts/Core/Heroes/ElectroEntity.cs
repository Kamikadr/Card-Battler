using Core.Effects.TakeDamage;
using UnityEngine;

namespace Core.Heroes
{
    public class ElectroEntity: BaseHeroEntity
    {
        [SerializeField] private int abilityDamage;
        
        protected override void OnInitialize()
        {
            AddEffect<TakeDamageEffect>(new MassAttackEffect(this, abilityDamage));
        }
    }
}