using Core.Events;
using Core.Handlers;
using UI;

namespace Core.Tasks
{
    public class PlayerTurnTask
    {
        private readonly EventBus _eventBus;
        private readonly IPlayerListenable _heroContainer;

        public PlayerTurnTask(EventBus eventBus ,IPlayerListenable heroContainer)
        {
            _eventBus = eventBus;
            _heroContainer = heroContainer;
        }

        public void Run()
        {
            _heroContainer.EnemyHeroList.OnHeroClicked += OnEnemyHeroChoose;
        }

        private void OnEnemyHeroChoose(HeroView hero)
        {
            _eventBus.RaiseEvent(new ChooseHeroEvent{HeroList = _heroContainer.FriendHeroList});
        }
    }
}