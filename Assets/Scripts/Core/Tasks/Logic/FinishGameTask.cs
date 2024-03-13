﻿using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Core.Tasks.Logic
{
    public sealed class FinishGameTask: BaseTask
    {
        protected override UniTask OnRun()
        {
            Debug.Log("Finish Game");
            Finish();
            return UniTask.CompletedTask;
        }
    }
}