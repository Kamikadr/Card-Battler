using Core.Effects;

namespace Core.Heroes
{
    public class HunterEntity: BaseHeroEntity
    {
        protected override void OnInitialize()
        {
            AddEffect(new BackAttackEvade());
        }
    }
}