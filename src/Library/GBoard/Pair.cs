

namespace GBoard
{

    // Se crea el tipo genérico Pair que es necesario dentro de la clase gameboard. Es funcionalmente idéntico a una 2-Tupla con la característica
    // de que es mutable. Se podría usar también una lista o algun objeto de propósito más general pero se optó por una solución más concreta y específica
    // así como también restringida estrictamente a la función para la que se requiere.
    


    /// <summary>
    /// Represents a mutable pair of two objects with the second one having the chance of being unprovided
    /// </summary>
    public class Pair<T1, T2>
    {
        /// <summary>
        /// Gets or sets the first element of the pair.
        /// </summary>
        public T1 First { get; set; }

        /// <summary>
        /// Gets or sets the second element of the pair.
        /// </summary>
        public T2? Second { get; set; } = default(T2);

        /// <summary>
        /// Initializes a new instance of the <see cref="Pair{T1, T2}"/> class with specified values.
        /// </summary>
        /// <param name="item1">The value for the first element of the pair.</param>
        /// <param name="item2">The value for the second element of the pair (optional).</param>
        public Pair(T1 item1, T2? item2 = default)
        {
            this.First = item1;
            this.Second = item2;
        }
    }
}
