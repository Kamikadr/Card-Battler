namespace Core.Effects
{
    public class ImmovableEffect: BaseEffect
    {
        public int Duration;

        public ImmovableEffect(HeroEntity source, int duration = -1) : base(source)
        {
            Duration = duration;
        }
    }
}