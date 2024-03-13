namespace Core.Effects.TakeDamage
{
    public abstract class TakeDamageEffect: BaseEffect
    {
        protected TakeDamageEffect(HeroEntity source) : base(source)
        {
        }
    }
}