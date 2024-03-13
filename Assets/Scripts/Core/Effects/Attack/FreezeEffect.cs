namespace Core.Effects.Attack
{
    public sealed class FreezeEffect: AttackEffect
    {
        public readonly int FreezeDuration;

        public FreezeEffect(int freezeDuration, HeroEntity source): base(source)
        {
            FreezeDuration = freezeDuration;
        }
    }
}