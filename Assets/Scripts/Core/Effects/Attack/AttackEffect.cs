namespace Core.Effects
{
    public abstract class AttackEffect: TargetEffect
    {
        protected AttackEffect(HeroEntity source) : base(source)
        {
        }
    }
}