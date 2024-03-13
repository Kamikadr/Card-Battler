using System;
using Core.Components;
using Core.Events;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Core.Tasks
{
    public class EndTurnTask: BaseTask, IResultChecker
    {
        public event Action OnResultReceived;
        
        private readonly EventBus _eventBus;
        private readonly IHeroListenable _heroContainer;
        private readonly IPlayerListenable _playerContainer;

        public EndTurnTask(EventBus eventBus, IHeroListenable heroContainer, IPlayerListenable playerContainer)
        {
            _eventBus = eventBus;
            _heroContainer = heroContainer;
            _playerContainer = playerContainer;
        }

        protected override UniTask OnRun()
        {
            Debug.Log("End turn");
            _eventBus.RaiseEvent(new ActivityHeroEvent(_heroContainer.Value, false));
            
            if (CheckWinner())
            {
                OnResultReceived?.Invoke();
            }
            Finish();
            return UniTask.CompletedTask;
        }

        private bool CheckWinner()
        {
            var players = new[]
            {
                _playerContainer.EnemyHeroList,
                _playerContainer.FriendHeroList
            };

            foreach (var player in players)
            {
                var heroes = player.GetAll();
                var deathCounter = player.GetCount();

                foreach (var hero in heroes)
                {
                    if (hero.TryGetEntityComponent<DeathComponent>(out _))
                    {
                        deathCounter--;
                    }
                }

                if (deathCounter == 0)
                {
                    return true;
                }
            }

            return false;
        }

        
    }
}