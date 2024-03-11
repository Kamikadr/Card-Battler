using Core;
using Core.Handlers;
using Core.Handlers.Effects;
using Core.Pipeline;
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
            builder.Register<LogicPipelineInstaller>(Lifetime.Singleton);
            builder.Register<LogicPipelineRunner>(Lifetime.Singleton);
            builder.Register<HeroButtonListener>(Lifetime.Singleton);
            builder.RegisterComponentInHierarchy<UIService>();
            builder.Register<HeroContainer>(Lifetime.Singleton).As<IHeroListenable>().As<IHeroChangeable>();
            builder.Register<PlayerContainer>(Lifetime.Singleton).As<IPlayerListenable>().As<IPlayerChangeable>();

            RegisterHandlers(builder);
        }

        private void RegisterHandlers(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<AttackHandler>();
            builder.RegisterEntryPoint<BackAttackHandler>();
            builder.RegisterEntryPoint<DealDamageHandler>();
            builder.RegisterEntryPoint<DamageEffectHandler>();
        }
    }
}