namespace Core.Components
{
    public class TeamComponent: IComponent
    {
        public Team value { get; private set; }

        public TeamComponent(Team team)
        {
            value = team;
        }
    }
}