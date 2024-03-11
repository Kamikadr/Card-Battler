using Core.Events;

namespace Core.Tasks
{
    public class PlayerTask: BaseTask
    {
        private readonly EventBus _eventBus;
        private readonly HeroButtonListener _heroListeners;
        private readonly IHeroListenable _currentHero;

        public PlayerTask(EventBus eventBus ,HeroButtonListener heroListeners,
            IHeroListenable currentHero)
        {
            _eventBus = eventBus;
            _heroListeners = heroListeners;
            _currentHero = currentHero;
        }

        protected override void OnRun()
        {
            _heroListeners.OnEntityClick += OnEnemyHeroChoose;
        }

        private void OnEnemyHeroChoose(HeroEntity target)
        {
            var targetContainer = new HeroContainer{ Value = target };
            _eventBus.RaiseEvent(new PreAttackEvent(_currentHero, targetContainer));
            _eventBus.RaiseEvent(new AttackEvent(_currentHero, targetContainer));
            _eventBus.RaiseEvent(new BackAttackEvent(targetContainer, _currentHero));
        }
    }
}