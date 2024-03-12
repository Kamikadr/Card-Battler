namespace Core.Effects
{
    public abstract class BaseEffect
    {
        public readonly HeroEntity source;

        protected BaseEffect(HeroEntity source)
        {
            this.source = source;
        }
    }
}