namespace Core.Effects
{
    public abstract class TargetEffect: BaseEffect
    {
        public HeroEntity Target;

        protected TargetEffect(HeroEntity source) : base(source)
        {
        }
    }
}