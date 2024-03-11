using Core.Events;
using Core.Handlers;
using UI;

namespace Core.Tasks
{
    public class PlayerInputTask
    {
        private readonly EventBus _eventBus;
        private readonly HeroButtonListener _heroListeners;
        private readonly IHeroListenable _currentHero;

        public PlayerInputTask(EventBus eventBus ,HeroButtonListener heroListeners,
            IHeroListenable currentHero,
            IHeroChangeable currentTarget)
        {
            _eventBus = eventBus;
            _heroListeners = heroListeners;
            _currentHero = currentHero;
        }

        public void Run()
        {
            _heroListeners.OnEntityClick += OnEnemyHeroChoose;
        }

        private void OnEnemyHeroChoose(HeroEntity target)
        {
            var targetContainer = new HeroContainer{ Value = target };
            _eventBus.RaiseEvent(new AttackEvent(_currentHero, targetContainer));
        }
    }
}