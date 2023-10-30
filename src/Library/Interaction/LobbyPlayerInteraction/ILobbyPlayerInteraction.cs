using System;
using System.Collections;
using Matches;

namespace Interaction
{
    public interface ILobbyPlayerInteraction
    {

        public Tuple<int, int, bool> askForPositioning(Battleship battleship, User user);

        public void joinToMatch(Admin admin, User user2);

    }
}