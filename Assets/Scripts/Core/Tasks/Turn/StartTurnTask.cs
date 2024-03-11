using Core.Effects;

namespace Core.Tasks
{
    public class StartTurnTask: BaseTask
    {
        private readonly EventBus _eventBus;
        private readonly IPlayerListenable _currentPlayer;
        private readonly IHeroChangeable _currentHero;

        public StartTurnTask(EventBus eventBus ,IPlayerListenable currentPlayer, IHeroChangeable currentHero)
        {
            _eventBus = eventBus;
            _currentPlayer = currentPlayer;
            _currentHero = currentHero;
        }
        protected override void OnRun()
        {
            var hero = _currentPlayer.FriendHeroList.GetNext();
            
            while (hero.TryGetEffects<ImmovableEffect>(out var effects))
            {
                foreach (var effect in effects)
                {
                    _eventBus.RaiseEvent(effect);
                }
                hero = _currentPlayer.FriendHeroList.GetNext();
            }

            _currentHero.Value = hero;
        }
    }
}