using Core.DataContainers;
using Core.Effects.EndTurnGeneral;
using Core.Events;
using UnityEngine;

namespace Core.Handlers.Logic.Effects
{
    public sealed class EndTurnRandomHealEffectHandler: BaseHandler<EndTurnRandomHealEffect>
    {
        private readonly IPlayerListenable _playerContainer;

        public EndTurnRandomHealEffectHandler(EventBus.EventBus eventBus, IPlayerListenable playerContainer) : base(eventBus)
        {
            _playerContainer = playerContainer;
        }

        protected override void OnEventHandle(EndTurnRandomHealEffect evt)
        {
            var heroes = _playerContainer.FriendHeroList.GetAll();
            var target = heroes[Random.Range(0, heroes.Count)];
            EventBus.RaiseEvent(new HealEvent(target, evt.HealValue));
        }
    }
}