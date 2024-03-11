using System;
using Core.Events;
using UI;

namespace Core.Handlers
{
    public class InputHandler: BaseHandler<ChooseEnemyHeroEvent>
    {
        private readonly IPlayerListenable _playerListenable;
        private HeroView _currentSource;

        public InputHandler(EventBus eventBus, IPlayerListenable playerListenable): base(eventBus)
        {
            _playerListenable = playerListenable;
        }
        protected override void OnEventHandle(ChooseEnemyHeroEvent evt)
        {
            _currentSource = evt.Target;
            //_playerListenable.EnemyHeroList.OnHeroClicked += OnChooseTarget;
        }

        private void OnChooseTarget(HeroView obj)
        {
            //EventBus.RaiseEvent(new AttackEvent{Target = obj, Source = _currentSource});
            _currentSource = null;
        }
    }

    public class ChooseEnemyHeroEvent
    {
        public HeroView Target;
    }
}