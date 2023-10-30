using System;
using System.Collections;
using System.Collections.Generic; // Add this line to import the List<T> class

namespace Matches
{
    /// <summary>
    /// Represents a class that defines possible game moves.
    /// </summary>
    public class Jugada
    {
        /*
        This class is SRP compliant because it only has the responsability
        to know the possible plays and have the methods named after the possible moves.
        */

        public static Tuple<int, int> TransformCoords(string input)
            {
                if (input.Length != 2)
                {
                    throw new ArgumentException("Input string must be of the format 'XN', where X is a letter and N is a number.");
                }

                char letter = input[0];
                char numberChar = input[1];

                if (!char.IsLetter(letter) || !char.IsDigit(numberChar))
                {
                    throw new ArgumentException("Input string must be of the format 'XN', where X is a letter and N is a number.");
                }

                int letterIndex = char.ToUpper(letter) - 'A' + 1; // Calculate the letter index (1 for 'A', 2 for 'B', etc.)
                int number = int.Parse(numberChar.ToString());

                return new Tuple<int, int>(letterIndex, number);
            }

        /// <summary>
        /// List of possible play names.
        /// </summary>
        public static List<string> PossiblePlays = new List<string> { "Attack" };

        /// <summary>
        /// Performs an "Attack" move at the specified coordinates.
        /// </summary>
        /// <param name="coords">A tuple representing the coordinates where the attack is performed.</param>
        public static string Attack(Tuple<int, int> coords, Gameboard gameboard)
        {
            if (gameboard.Board[coords.Item1 - 1, coords.Item2 - 1].First == 1)
            {
                return "Cell already hit";
            } else
            {
                gameboard.Board[coords.Item1 - 1, coords.Item2 - 1].First = 1;
                return "Cell hit successfully";
            }
            // Future implementation of the method, according to our needs.
        }
    }
}
