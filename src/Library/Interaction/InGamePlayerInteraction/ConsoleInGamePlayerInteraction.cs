using System;
using System.Collections;
using System.Reflection;
using Matches;

namespace Interaction
{

    /*
    This class meets with the SRP principle because it only has the responsibility
    to communicate with the user through the console.
    */
    

    /// <summary>
    /// Represents a class for interacting with an in-game player using the console.
    /// </summary>
    public class ConsoleInGamePlayerInteraction : IInGamePlayerInteraction
    {
        /// <summary>
        /// Asks the player for their next play and prints the request using the specified printer.
        /// </summary>
        /// <param name="printer">The printer used to display the request to the player.</param>
        public void askForPlayOverGameboard(Gameboard gameboard)
        {
            ConsolePrinter printer = new ConsolePrinter();

            printer.Print("Escriba la jugada a realizar: (ej.: Attack e7):   ");

            string[]? play = Console.ReadLine().Split(" ");

            if (play[0] == "Attack")
            {
                Jugada.Attack(Jugada.TransformCoords(play[1]), gameboard);
            }

            // Future implementation of the method, according to our needs.
        }

        /// <summary>
        /// Reports the current game status to the player.
        /// </summary>
        public void reportGameStatus(IMatch match)
        {

            // Deberia mandar un mensaje por algun medio (en este caso consola) con el tablero de los dos jugadores en funcion del matchStatus
            // Future implementation of the method, according to our needs.
        }
    }
}
