using Core.Effects;

namespace Core.Heroes
{
    public class IceMageEntity: BaseHeroEntity
    {
        protected override void OnInitialize()
        {
            AddEffect<AttackEffect>(new FreezeEffect(1, this));
        }
    }
}