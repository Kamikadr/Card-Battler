using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Core.Tasks
{
    public class EndTurnTask: BaseTask
    {
        protected override UniTask OnRun()
        {
            Debug.Log("End turn");
            Finish();
            return UniTask.CompletedTask;
        }
    }
}