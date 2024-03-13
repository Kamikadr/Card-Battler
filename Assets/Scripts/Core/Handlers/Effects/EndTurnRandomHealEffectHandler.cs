using Core.Effects.EndTurnGeneral;
using UnityEngine;

namespace Core.Handlers.Effects
{
    public class EndTurnRandomHealEffectHandler: BaseHandler<EndTurnRandomHealEffect>
    {
        private readonly IPlayerListenable _playerContainer;

        public EndTurnRandomHealEffectHandler(EventBus eventBus, IPlayerListenable playerContainer) : base(eventBus)
        {
            _playerContainer = playerContainer;
        }

        protected override void OnEventHandle(EndTurnRandomHealEffect evt)
        {
            var heroes = _playerContainer.FriendHeroList.GetAll();
            var target = heroes[Random.Range(0, heroes.Count)];
            EventBus.RaiseEvent(new HealEvent(target, evt.healValue));
        }
    }
}