using System;
using System.Collections;

namespace Interaction
{
    /// <summary>
    /// This class implements the IPrinter interface and provides a way to print messages to the console.
    /// </summary>
    public class ConsolePrinter : IPrinter
    {
        /*
        This class meets with the SRP principle because it only has the responsibility
        to print the desired string in the console.
        */
        
        /// <summary>
        /// Prints the specified string to the console.
        /// </summary>
        /// <param name="str">The string to be printed.</param>
        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
