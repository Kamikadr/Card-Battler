using Core.Effects.PreAttack;

namespace Game.Heroes
{
    public sealed class DumbOrcEntity: BaseHeroEntity
    {
        protected override void OnInitialize()
        {
            AddEffect<PreAttackEffect>(new ChangeTargetEffect(this));
        }
    }
}