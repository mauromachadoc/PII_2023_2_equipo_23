using System;
using System.Collections;

namespace Interaction
{
    /// <summary>
    /// Represents an interface for reader classes.
    /// </summary>
    public interface IReader
    {
        /*
        This interface meets polymorphism because its subtypes are able to 
        fulfill its duty properly.
        */
        /// <summary>
        /// Reads and returns a string from a data source.
        /// </summary>
        /// <returns>The string read from the data source.</returns>
        string Read();
    }
}
