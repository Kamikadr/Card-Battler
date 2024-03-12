namespace Core.Effects
{
    public class FreezeEffect: AttackEffect
    {
        public readonly int freezeDuration;

        public FreezeEffect(int freezeDuration, HeroEntity source): base(source)
        {
            this.freezeDuration = freezeDuration;
        }
    }
}