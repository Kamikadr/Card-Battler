using Core.Effects.PreAttack;

namespace Core.Heroes
{
    public class DumbOrcEntity: BaseHeroEntity
    {
        protected override void OnInitialize()
        {
            AddEffect(new ChangeTargetEffect(this));
        }
    }
}