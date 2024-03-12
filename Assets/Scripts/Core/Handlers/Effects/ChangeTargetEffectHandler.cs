using Core.Effects.PreAttack;
using UnityEngine;

namespace Core.Handlers.Effects
{
    public class ChangeTargetEffectHandler: BaseHandler<ChangeTargetEffect>
    {
        private readonly IPlayerListenable _playerContainer;

        public ChangeTargetEffectHandler(EventBus eventBus, IPlayerListenable playerContainer) : base(eventBus)
        {
            _playerContainer = playerContainer;
        }

        protected override void OnEventHandle(ChangeTargetEffect evt)
        {
            var random = Random.value;
            if (random >= 0.5f)
            {
                
            }
        }
    }
}