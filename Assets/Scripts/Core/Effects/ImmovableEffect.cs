namespace Core.Effects
{
    public class ImmovableEffect: BaseEffect
    {
        public int duration;

        public ImmovableEffect(int duration = -1)
        {
            this.duration = duration;
        }
    }
}