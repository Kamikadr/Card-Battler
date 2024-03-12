namespace Core.Effects
{
    public class ImmovableEffect: BaseEffect
    {
        public int duration;

        public ImmovableEffect(HeroEntity source, int duration = -1) : base(source)
        {
            this.duration = duration;
        }
    }
}