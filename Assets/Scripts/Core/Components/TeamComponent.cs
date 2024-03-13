using Game;

namespace Core.Components
{
    public sealed class TeamComponent: IComponent
    {
        public Team value { get; private set; }

        public TeamComponent(Team team)
        {
            value = team;
        }
    }
}