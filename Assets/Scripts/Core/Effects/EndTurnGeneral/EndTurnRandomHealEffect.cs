namespace Core.Effects.EndTurnGeneral
{
    public class EndTurnRandomHealEffect: EndTurnGeneralEffect
    {
        public readonly int healValue;

        public EndTurnRandomHealEffect(int healValue, HeroEntity source) : base(source)
        {
            this.healValue = healValue;
        }
    }
}