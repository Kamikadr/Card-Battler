using System.Collections;
using System.Collections.Generic;
using UI;

namespace Core
{
    public interface IPlayerChangeable: IPlayerListenable
    {
        void SwitchPlayers();
    }
}