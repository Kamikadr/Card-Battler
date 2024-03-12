using System;
using Core.Components;
using Core.Effects;
using Core.Handlers;
using UI;
using UnityEngine;

namespace Core
{
    [RequireComponent(typeof(HeroView))]
    public abstract  class BaseHeroEntity: HeroEntity
    {
        [SerializeField] private int baseHealth;
        [SerializeField] private int baseDamage;
        [SerializeField] private Team team;

        private void Initialize()
        {
            AddComponent(new HealthComponent(baseHealth));
            AddComponent(new DamageComponent(baseDamage));
            AddComponent(new TeamComponent(team));
            AddComponent(new TeamComponent(team));
            AddComponent(new HeroViewComponent(GetComponent<HeroView>()));
            
            AddEffect<AttackEffect>(new DamageEffect());
            
            OnInitialize();
        }

        public void InitializeHero()
        {
            ClearEntity();
            Initialize();
        }

        protected abstract void OnInitialize();
    }

    public enum Team
    {
        Red,
        Blue
    }
}