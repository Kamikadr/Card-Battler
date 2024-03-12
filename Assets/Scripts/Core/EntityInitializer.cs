using System.Collections.Generic;
using Core.Components;
using Core.Events;
using Core.Handlers;
using UnityEngine;

namespace Core
{
    public class EntityInitializer
    {
        private readonly IPlayerListenable _playerListenable;

        public EntityInitializer(IPlayerListenable playerListenable)
        {
            _playerListenable = playerListenable;
        }
        public void SetupEntity()
        {
            var entities = new List<BaseHeroEntity>();
            entities.AddRange(_playerListenable.FriendHeroList.GetAll());
            entities.AddRange(_playerListenable.EnemyHeroList.GetAll());

            foreach (var entity in entities)
            {
                entity.InitializeHero();
                HeroView(entity);
            }
            
        }

        private static void HeroView(BaseHeroEntity entity)
        {
            var heroView = entity.GetEntityComponent<HeroViewComponent>();
            var heroHealth = entity.GetEntityComponent<HealthComponent>();
            var heroDamage = entity.GetEntityComponent<DamageComponent>();
            heroView.Value.SetStats($"{heroDamage.Value} / {heroHealth.currentHealth}");
        }
    }
}