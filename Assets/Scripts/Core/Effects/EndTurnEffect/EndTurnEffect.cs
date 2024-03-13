namespace Core.Effects.EndTurnEffect
{
    public abstract class EndTurnEffect: BaseEffect
    {
        protected EndTurnEffect(HeroEntity source) : base(source)
        {
        }
    }
}