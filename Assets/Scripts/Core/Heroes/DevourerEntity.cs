using Core.Components;
using Core.Handlers;
using UnityEngine;
using Core.Effects.EndTurnEffect;

namespace Core.Heroes
{
    public class DevourerEntity: HeroEntity
    {
        [SerializeField] private int baseHealth;
        [SerializeField] private int baseDamage;
        [SerializeField] private int abilityDamage;
        protected override void Initialize()
        {
            AddComponent(new HealthComponent(baseHealth));
            AddComponent(new DamageComponent(baseDamage));
            
            AddEffect<EndTurnEffect>(new DealDamageToRandomTargetEffect(abilityDamage));
        }
    }
}