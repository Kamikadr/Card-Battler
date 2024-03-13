namespace Core.Components
{
    public sealed class HealthComponent: IComponent
    {
        public readonly int MaxHealth;
        public int CurrentHealth;

        public HealthComponent(int maxHp)
        {
            MaxHealth = maxHp;
            CurrentHealth = maxHp;
        }

        public void RefreshComponent()
        {
            CurrentHealth = MaxHealth;
        }
    }
}