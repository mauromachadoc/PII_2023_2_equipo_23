using System;
using System.Collections;

namespace Interaction
{
    /// <summary>
    /// This class implements the IReader interface and provides a way to read text input from the console.
    /// </summary>
    public class ConsoleReader : IReader
    {
        /*
        This class meets with the SRP principle because it only has the responsibility
        to read a string from the console.
        */

        /// <summary>
        /// Reads text input from the console.
        /// </summary>
        /// <returns>The text input read from the console.</returns>
        public string Read()
        {
            while (true)
            {
                string reading = Console.ReadLine();
                if (!String.IsNullOrEmpty(reading))
                {
                    return reading;
                }
            }
        }
    }
}
