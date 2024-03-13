using System.Collections.Generic;
using Core;
using Core.Components;
using Core.DataContainers;
using Game.Heroes;

namespace Game
{
    public sealed class GameInitializer
    {
        private readonly IPlayerListenable _playerListenable;

        public GameInitializer(IPlayerListenable playerListenable)
        {
            _playerListenable = playerListenable;
        }

        public void SetupGame()
        {
            SetupEntity();
            SetupContainers();
        }

        private void SetupContainers()
        {
            _playerListenable.FriendHeroList.Refresh();
            _playerListenable.EnemyHeroList.Refresh();
        }

        private void SetupEntity()
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
            heroView.Value.SetStats($"{heroDamage.Value} / {heroHealth.CurrentHealth}");
        }
    }
}