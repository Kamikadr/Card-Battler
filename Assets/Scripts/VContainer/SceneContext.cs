using Core;
using Core.Effects;
using Core.Handlers;
using Core.Handlers.Effects;
using Core.Handlers.Visual;
using Core.Pipeline;
using Core.Tasks;
using Core.Tasks.Visual;
using UI;
using VContainer.Unity;

namespace VContainer
{
    public class SceneContext: LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<LogicPipeline>(Lifetime.Singleton);
            builder.Register<VisualPipeline>(Lifetime.Singleton);
            builder.Register<EventBus>(Lifetime.Singleton);
            builder.Register<HeroContainer>(Lifetime.Singleton);
            builder.Register<LogicPipelineInstaller>(Lifetime.Singleton).AsImplementedInterfaces();
            builder.Register<LogicPipelineRunner>(Lifetime.Singleton);
            builder.Register<HeroButtonListener>(Lifetime.Singleton);
            builder.Register<EntityInitializer>(Lifetime.Singleton);
            builder.Register<PlayerContainerBuilder>(Lifetime.Singleton).AsImplementedInterfaces();
            builder.RegisterComponentInHierarchy<UIService>();
            builder.Register<HeroContainer>(Lifetime.Singleton).As<IHeroListenable>().As<IHeroChangeable>();
            builder.Register<PlayerContainer>(Lifetime.Singleton).As<IPlayerListenable>().As<IPlayerChangeable>().AsSelf();

            RegisterHandlers(builder);
            RegisterTasks(builder);
        }

        private void RegisterTasks(IContainerBuilder builder)
        {
            builder.Register<StartGameTask>(Lifetime.Singleton);
            builder.Register<StartTurnTask>(Lifetime.Singleton);
            builder.Register<PlayerTask>(Lifetime.Singleton);
            builder.Register<EndTurnTask>(Lifetime.Singleton);
            builder.Register<EndTurnAbilityTask>(Lifetime.Singleton);
            builder.Register<EndTurnGeneralAbilityTask>(Lifetime.Singleton);
            builder.Register<VisualPipelineRunTask>(Lifetime.Singleton);
            builder.Register<SwitchPlayerTask>(Lifetime.Singleton);
            builder.Register<FinishGameTask>(Lifetime.Singleton);
        }

        private void RegisterHandlers(IContainerBuilder builder)
        {
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
            
            
            builder.RegisterEntryPoint<AttackVisualHandler>();
            builder.RegisterEntryPoint<HealVisualHandler>();
            builder.RegisterEntryPoint<DealDamageVisualHandler>();
            builder.RegisterEntryPoint<ActivityHeroVisualHandler>();
        }
    }
}