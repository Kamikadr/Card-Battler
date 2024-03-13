namespace Core.Effects.Attack
{
    public abstract class AttackEffect: TargetEffect
    {
        protected AttackEffect(HeroEntity source) : base(source)
        {
        }
    }
}