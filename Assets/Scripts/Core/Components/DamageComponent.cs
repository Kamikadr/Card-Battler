namespace Core.Components
{
    public class DamageComponent: IComponent
    {
        public int Value;

        public DamageComponent(int damage)
        {
            Value = damage;
        }
    }
}