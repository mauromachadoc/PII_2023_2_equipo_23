using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.IO; // Import the System.IO namespace for File.ReadAllText

namespace Interaction
{
    /// <summary>
    /// This class implements the IReader interface and provides a way to read text from a file.
    /// </summary>
    public class FileReader : IReader
    {
        /*
        This class meets with the SRP principle because it only has the responsibility
        to read the content of a file.
        */

        /// <summary>
        /// Reads text from a file named "archivoDeTexto.txt".
        /// </summary>
        /// <returns>The text read from the file.</returns>
        public string Read()
        {
            // Read the text from the file named "archivoDeTexto.txt"
            string txt = File.ReadAllText("archivoDeTexto.txt");
            return txt;
        }
    }
}
