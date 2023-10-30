using System;
using System.Collections;
using Matches;

namespace Interaction
{
    /// <summary>
    /// Represents an interface for interactions with an in-game player.
    /// </summary>
    public interface IInGamePlayerInteraction
    {
        /*
        This interface meets polymorphism because its subtypes are able to 
        fulfill its duty properly.
        */

        /// <summary>
        /// Asks the player for their next play and prints the request using the specified printer.
        /// </summary>
        /// <param name="printer">The printer used to display the request to the player.</param>
        public void askForPlayOverGameboard(Gameboard gameboard);

        /// <summary>
        /// Reports the current game status to the player.
        /// </summary>
        public void reportGameStatus(IMatch match);
    }
}
