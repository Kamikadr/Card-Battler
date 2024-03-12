using Core.Components;

namespace Core.Handlers
{
    public class HealthComponent: IComponent
    {
        public readonly int maxHealth;
        public int currentHealth;

        public HealthComponent(int maxHp)
        {
            maxHealth = maxHp;
            currentHealth = maxHp;
        }

        public void RefreshComponent()
        {
            currentHealth = maxHealth;
        }
    }
}