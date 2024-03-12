using System;
using Core.Pipeline;
using UnityEngine;
using VContainer;

namespace Core
{
    public class Game: MonoBehaviour
    {
        
        [SerializeField] private bool isPlaying = false; 
        [SerializeField] private bool autoRun; 
        private LogicPipelineRunner _logicPipelineRunner;
        private EntityInitializer _entityInitializer;

        [Inject]
        private void Construct(LogicPipelineRunner logicPipelineRunner, EntityInitializer entityInitializer)
        {
            _logicPipelineRunner = logicPipelineRunner;
            _entityInitializer = entityInitializer;
        }
        private void Start()
        {
            StartGame();
        }

        public void StartGame()
        {
            isPlaying = true;
            _entityInitializer.SetupEntity();
            _logicPipelineRunner.Run(autoRun);
        }
    }
}