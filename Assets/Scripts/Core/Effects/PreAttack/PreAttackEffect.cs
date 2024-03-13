namespace Core.Effects.PreAttack
{
    public abstract class PreAttackEffect: TargetEffect
    {
        protected PreAttackEffect(HeroEntity source) : base(source)
        {
        }
    }
}