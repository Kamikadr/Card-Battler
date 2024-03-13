using Core.Effects.Attack;

namespace Game.Heroes
{
    public sealed class IceMageEntity: BaseHeroEntity
    {
        protected override void OnInitialize()
        {
            AddEffect<AttackEffect>(new FreezeEffect(1, this));
        }
    }
}