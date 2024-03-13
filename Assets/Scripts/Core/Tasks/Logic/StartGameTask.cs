using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Core.Tasks.Logic
{
    public sealed class StartGameTask: BaseTask
    {
        protected override UniTask OnRun()
        {
            Debug.Log("Start Game");
            Finish();
            return UniTask.CompletedTask;
        }
    }
}