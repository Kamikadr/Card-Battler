using System.Collections.Generic;
using Core.Events;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Core.Tasks
{
    public class StartGameTask: BaseTask
    {
        private readonly IPlayerListenable _playerListenable;
        private readonly EventBus _eventBus;

        public StartGameTask(IPlayerListenable playerListenable, EventBus eventBus)
        {
            _playerListenable = playerListenable;
            _eventBus = eventBus;
        }
        protected override UniTask OnRun()
        {
            Debug.Log("Start Game");
            var entities = new List<BaseHeroEntity>();
            entities.AddRange(_playerListenable.FriendHeroList.GetAll());
            entities.AddRange(_playerListenable.EnemyHeroList.GetAll());

            foreach (var entity in entities)
            {
                _eventBus.RaiseEvent(new RefreshHeroEvent(entity));
            }

            Finish();
            return UniTask.CompletedTask;
        }
    }
}