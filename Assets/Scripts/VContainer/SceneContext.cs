using Core;
using Core.DataContainers;
using Core.EventBus;
using Core.Handlers.Logic.Common;
using Core.Handlers.Logic.Effects;
using Core.Handlers.Visual.Common;
using Core.Handlers.Visual.Effects;
using Core.Pipeline;
using Core.Tasks.Logic;
using Game;
using UI;
using VContainer.Unity;

namespace VContainer
{
    public sealed class SceneContext: LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            RegisterPipelines(builder);
            RegisterDataContainers(builder);
            RegisterHandlers(builder);
            RegisterTasks(builder);
            
            builder.Register<EventBus>(Lifetime.Singleton);
            builder.Register<HeroButtonListener>(Lifetime.Singleton);
            builder.Register<GameInitializer>(Lifetime.Singleton);
            builder.RegisterComponentInHierarchy<UIService>();
            builder.RegisterEntryPoint<ResultController>();
        }

        private static void RegisterPipelines(IContainerBuilder builder)
        {
            builder.Register<LogicPipelineInstaller>(Lifetime.Singleton).AsImplementedInterfaces();
            builder.Register<LogicPipelineRunner>(Lifetime.Singleton);
            builder.Register<LogicPipeline>(Lifetime.Singleton);
            builder.Register<VisualPipeline>(Lifetime.Singleton);
        }

        private void RegisterDataContainers(IContainerBuilder builder)
        {
            builder.Register<TargetProvider>(Lifetime.Singleton);
            builder.Register<HeroContainer>(Lifetime.Singleton).As<IHeroListenable>().As<IHeroChangeable>();
            builder.Register<PlayerContainer>(Lifetime.Singleton).As<IPlayerListenable>().As<IPlayerChangeable>().AsSelf();
            builder.Register<PlayerContainerBuilder>(Lifetime.Singleton).AsImplementedInterfaces();
        }

        private void RegisterTasks(IContainerBuilder builder)
        {
            builder.Register<StartGameTask>(Lifetime.Singleton);
            builder.Register<StartTurnTask>(Lifetime.Singleton);
            builder.Register<PlayerTask>(Lifetime.Singleton);
            builder.Register<EndTurnTask>(Lifetime.Singleton).AsImplementedInterfaces().AsSelf();
            builder.Register<EndTurnAbilityTask>(Lifetime.Singleton);
            builder.Register<EndTurnGeneralAbilityTask>(Lifetime.Singleton);
            builder.Register<VisualPipelineRunTask>(Lifetime.Singleton);
            builder.Register<SwitchPlayerTask>(Lifetime.Singleton);
            builder.Register<FinishGameTask>(Lifetime.Singleton);
        }

        private void RegisterHandlers(IContainerBuilder builder)
        {
            //Logic Handlers
            builder.RegisterEntryPoint<AttackHandler>();
            builder.RegisterEntryPoint<BackAttackHandler>();
            builder.RegisterEntryPoint<DealDamageHandler>();
            builder.RegisterEntryPoint<DamageEffectHandler>();
            builder.RegisterEntryPoint<DealDamageToRandomTargetHandler>();
            builder.RegisterEntryPoint<LifestealEffectHandler>();
            builder.RegisterEntryPoint<DamageAbsorptionEffectHandler>();
            builder.RegisterEntryPoint<FreezeEffectHandler>();
            builder.RegisterEntryPoint<ImmovableEffectHandler>();
            builder.RegisterEntryPoint<EndTurnRandomHealEffectHandler>();
            builder.RegisterEntryPoint<HealHandler>();
            builder.RegisterEntryPoint<MassAttackEffectHandler>();
            builder.RegisterEntryPoint<DeathHandler>();
            builder.RegisterEntryPoint<ChangeTargetEffectHandler>();
            builder.RegisterEntryPoint<PreAttackHandler>();
            
            // Visual Handlers
            builder.RegisterEntryPoint<AttackVisualHandler>();
            builder.RegisterEntryPoint<HealVisualHandler>();
            builder.RegisterEntryPoint<DealDamageVisualHandler>();
            builder.RegisterEntryPoint<ActivityHeroVisualHandler>();
            builder.RegisterEntryPoint<DeathVisualHandler>();
            builder.RegisterEntryPoint<EndTurnRandomHealEffectVisualHandler>();
            builder.RegisterEntryPoint<MassAttackVisualHandler>();
        }
    }
}