namespace Core.Effects
{
    public class FreezeEffect: AttackEffect
    {
        public readonly int freezeDuration;

        public FreezeEffect(int freezeDuration)
        {
            this.freezeDuration = freezeDuration;
        }
    }
}