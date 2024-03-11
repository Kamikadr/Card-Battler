namespace Core.Effects.EndTurnEffect
{
    public class DealDamageToRandomTargetEffect: EndTurnEffect
    {
        public int Damage { get; }

        public DealDamageToRandomTargetEffect(int damage)
        {
            Damage = damage;
        }
    }
}