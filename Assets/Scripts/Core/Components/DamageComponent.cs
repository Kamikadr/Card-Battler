namespace Core.Components
{
    public sealed class DamageComponent: IComponent
    {
        public readonly int Value;

        public DamageComponent(int damage)
        {
            Value = damage;
        }
    }
}