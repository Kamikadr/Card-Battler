using Core.Effects.EndTurnEffect;
using Core.Events;
using UnityEngine;


namespace Core.Handlers.Effects
{
    public class DealDamageToRandomTargetHandler: BaseHandler<DealDamageToRandomTargetEffect>
    {
        private readonly IPlayerListenable _playerListenable;

        public DealDamageToRandomTargetHandler(EventBus eventBus, IPlayerListenable playerListenable) : base(eventBus)
        {
            _playerListenable = playerListenable;
        }

        protected override void OnEventHandle(DealDamageToRandomTargetEffect evt)
        {
            var enemyList = _playerListenable.EnemyHeroList;
            var randomIndex = Random.Range(0, enemyList.GetCount());
            EventBus.RaiseEvent(new DealDamageEvent(evt.Damage, enemyList.GetByIndex(randomIndex)));
        }
    }
}