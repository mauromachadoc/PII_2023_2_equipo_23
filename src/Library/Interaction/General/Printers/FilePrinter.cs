using System;
using System.Collections;
using System.IO; // Import the System.IO namespace for File.WriteAllText

namespace Interaction
{
    /// <summary>
    /// This class implements the IPrinter interface and provides a way to print a string to a file.
    /// </summary>
    public class FilePrinter : IPrinter
    {
        /*
        This class meets with the SRP principle because it only has the responsibility
        to print the desire string in a file.
        */

        /// <summary>
        /// Prints the specified string to a file.
        /// </summary>
        /// <param name="str">The string to be printed to the file.</param>
        public void Print(string str)
        {
            // Write the string to a text file named "archivoDeTexto.txt"
            File.WriteAllText("archivoDeTexto.txt", str);
        }
    }
}
