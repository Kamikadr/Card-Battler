﻿using Core.Effects.TakeDamage;
using Core.Pipeline;
using Core.Tasks.Visual.Effects;

namespace Core.Handlers.Visual.Effects
{
    public sealed class MassAttackVisualHandler: BaseVisualHandler<MassAttackEffect>
    {
        public MassAttackVisualHandler(EventBus.EventBus eventBus, VisualPipeline visualPipeline) : base(eventBus, visualPipeline)
        {
        }

        protected override void OnEventHandle(MassAttackEffect evt)
        {
            _visualPipeline.AddTask(new MassAttackEffectVisualTask(evt.Source));
        }
    }
}