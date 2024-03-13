namespace Core.Effects.EndTurnGeneral
{
    public sealed class EndTurnRandomHealEffect: EndTurnGeneralEffect
    {
        public readonly int HealValue;

        public EndTurnRandomHealEffect(int healValue, HeroEntity source) : base(source)
        {
            HealValue = healValue;
        }
    }
}