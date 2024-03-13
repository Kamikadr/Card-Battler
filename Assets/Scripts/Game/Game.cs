using Core.Pipeline;
using Sirenix.OdinInspector;
using UnityEngine;
using VContainer;

namespace Game
{
    public sealed class Game: MonoBehaviour
    {
        
        [SerializeField, ReadOnly] private bool isPlaying = false; 
        [SerializeField] private bool autoRun; 
        private LogicPipelineRunner _logicPipelineRunner;
        private GameInitializer _gameInitializer;

        [Inject]
        private void Construct(LogicPipelineRunner logicPipelineRunner, GameInitializer gameInitializer)
        {
            _logicPipelineRunner = logicPipelineRunner;
            _gameInitializer = gameInitializer;
        }
        private void Start()
        {
            StartGame();
        }
        
        [Button]
        private void StartGame()
        {
            isPlaying = true;
            _gameInitializer.SetupGame();
            _logicPipelineRunner.Run(autoRun);
            _logicPipelineRunner.OnRunStopped += OnRunEnd;
        }

        private void OnRunEnd()
        {
            isPlaying = false;
            _logicPipelineRunner.OnRunStopped -= OnRunEnd;
        }

        [Button]
        private void RunTasks()
        {
            if (isPlaying)
            {
                return;
            }
            _logicPipelineRunner.Run(false);
        }
    }
}