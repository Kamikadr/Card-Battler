using Core.Events;

namespace Core.Effects
{
    public abstract class BaseEffect: IEvent
    {
        public readonly HeroEntity Source;

        protected BaseEffect(HeroEntity source)
        {
            this.Source = source;
        }
    }
}