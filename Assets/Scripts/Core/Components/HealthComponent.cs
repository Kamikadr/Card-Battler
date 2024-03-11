using Core.Components;

namespace Core.Handlers
{
    public class HealthComponent: IComponent
    {
        private int _maxHealth;
        public int currentHealth;

        public HealthComponent(int maxHp)
        {
            _maxHealth = maxHp;
            currentHealth = maxHp;
        }

        public void RefreshComponent()
        {
            currentHealth = _maxHealth;
        }
    }
}