namespace Core.Effects
{
    public abstract class BaseEffect: IEvent
    {
        public readonly HeroEntity source;

        protected BaseEffect(HeroEntity source)
        {
            this.source = source;
        }
    }
}