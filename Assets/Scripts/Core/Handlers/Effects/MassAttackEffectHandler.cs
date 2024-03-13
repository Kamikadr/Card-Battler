using System.Collections.Generic;
using Core.Effects.TakeDamage;
using Core.Events;

namespace Core.Handlers.Effects
{
    public class MassAttackEffectHandler: BaseHandler<MassAttackEffect>
    {
        private readonly IPlayerListenable _playerContainer;

        public MassAttackEffectHandler(EventBus eventBus, IPlayerListenable playerContainer) : base(eventBus)
        {
            _playerContainer = playerContainer;
        }

        protected override void OnEventHandle(MassAttackEffect evt)
        {
            var heroes = new List<HeroEntity>();
            heroes.AddRange(_playerContainer.FriendHeroList.GetAll());
            heroes.AddRange(_playerContainer.EnemyHeroList.GetAll());

            heroes.Remove(evt.source);
            foreach (var hero in heroes)
            {
                EventBus.RaiseEvent(new DealDamageEvent(evt.damage, hero));
            }
        }
    }
}