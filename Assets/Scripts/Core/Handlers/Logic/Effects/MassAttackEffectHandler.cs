﻿using System.Collections.Generic;
using Core.Components;
using Core.DataContainers;
using Core.Effects.TakeDamage;
using Core.Events;

namespace Core.Handlers.Logic.Effects
{
    public sealed class MassAttackEffectHandler: BaseHandler<MassAttackEffect>
    {
        private readonly IPlayerListenable _playerContainer;

        public MassAttackEffectHandler(EventBus.EventBus eventBus, IPlayerListenable playerContainer) : base(eventBus)
        {
            _playerContainer = playerContainer;
        }

        protected override void OnEventHandle(MassAttackEffect evt)
        {
            var heroes = new List<HeroEntity>();
            heroes.AddRange(_playerContainer.FriendHeroList.GetAll());
            heroes.AddRange(_playerContainer.EnemyHeroList.GetAll());

            heroes.Remove(evt.Source);
            foreach (var hero in heroes)
            {
                if (!hero.TryGetEntityComponent<DeathComponent>(out _))
                {
                    EventBus.RaiseEvent(new DealDamageEvent(evt.Damage, hero));
                }
            }
        }
    }
}