using System.Linq;
using Core.Components;
using Core.Effects.PreAttack;
using UnityEngine;

namespace Core.Handlers.Effects
{
    public class ChangeTargetEffectHandler: BaseHandler<ChangeTargetEffect>
    {
        private readonly IPlayerListenable _playerContainer;
        private readonly TargetProvider _targetProvider;

        public ChangeTargetEffectHandler(EventBus eventBus, IPlayerListenable playerContainer, TargetProvider targetProvider) : base(eventBus)
        {
            _playerContainer = playerContainer;
            _targetProvider = targetProvider;
        }

        protected override void OnEventHandle(ChangeTargetEffect evt)
        {
            var random = Random.value;
            if (random >= 0.5f)
            {
                var enemies = _playerContainer.EnemyHeroList.GetAll().ToList();
                var randomNumber = Random.Range(0, enemies.Count - 1);
                while (enemies[randomNumber].TryGetEntityComponent<DeathComponent>(out _))
                {
                    enemies.RemoveAt(randomNumber);
                    randomNumber = Random.Range(0, enemies.Count - 1);
                }

                _targetProvider.HeroContainer.Value = enemies[randomNumber];
            }
        }
    }
}