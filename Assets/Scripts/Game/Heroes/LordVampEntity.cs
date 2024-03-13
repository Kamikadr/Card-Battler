using Core.Effects.Attack;

namespace Game.Heroes
{
    public sealed class LordVampEntity: BaseHeroEntity
    {
        protected override void OnInitialize()
        {
            AddEffect<AttackEffect>(new LifestealEffect(this));
        }
    }
}