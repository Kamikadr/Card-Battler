namespace Core.DataContainers
{
    public interface IPlayerChangeable: IPlayerListenable
    {
        void SwitchPlayers();
    }
}