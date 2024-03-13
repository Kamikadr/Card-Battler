using Core.Effects;

namespace Game.Heroes
{
    public sealed class HunterEntity: BaseHeroEntity
    {
        protected override void OnInitialize()
        {
            AddEffect(new BackAttackEvade(this));
        }
    }
}