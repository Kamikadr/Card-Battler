using Core.Effects;

namespace Core.Heroes
{
    public class LordVampEntity: BaseHeroEntity
    {
        protected override void OnInitialize()
        {
            AddEffect<AttackEffect>(new LifestealEffect(this));
        }
    }
}