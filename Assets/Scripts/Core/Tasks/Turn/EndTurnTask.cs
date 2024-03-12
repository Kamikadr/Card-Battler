﻿using Core.Events;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Core.Tasks
{
    public class EndTurnTask: BaseTask
    {
        private readonly EventBus _eventBus;
        private readonly IHeroListenable _heroContainer;

        public EndTurnTask(EventBus eventBus, IHeroListenable heroContainer)
        {
            _eventBus = eventBus;
            _heroContainer = heroContainer;
        }

        protected override UniTask OnRun()
        {
            Debug.Log("End turn");
            _eventBus.RaiseEvent(new ActivityHeroEvent(_heroContainer.Value, false));
            Finish();
            return UniTask.CompletedTask;
        }
    }
}