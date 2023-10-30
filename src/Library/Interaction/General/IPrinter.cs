using System;
using System.Collections;

namespace Interaction
{
    /// <summary>
    /// Represents an interface for printer classes.
    /// </summary>
    public interface IPrinter
    {   
        /*
        This interface meets polymorphism because its subtypes are able to 
        fulfill its duty properly.
        */
        /// <summary>
        /// Prints the specified string.
        /// </summary>
        /// <param name="str">The string to be printed.</param>
        void Print(string str);
    }
}
