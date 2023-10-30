namespace GBoard
{

    // Se crea la clase Battleship cuya única responsabilidad es la de conocer la vida y el tamaño de una nave puntual. No existen motivos adicionales
    // al querer modificar las propiedades de una nave que instasen a un cambio en esta clase, cumpliéndose así SRP.
    // Dado que la clase Battleship cuenta con la responsabilidad de conocer una nave, conoce la información propia de esta, su vida y su tamaño. Siguiendo
    // así el patrón Expert.
    // Podría la clase Battleship almacenar también la ubicación de la nave pero funcional y semánticamente esta responsabilidad corresponde, siguiendo
    // también el patrón Expert, a la clase Gameboard.


    /// <summary>
    /// Represents a battleship status along with its properties
    /// </summary>
    public class Battleship
{
    /// <summary>
    /// Gets the size of the Battleship as a tuple representing its height and width.
    /// </summary>
    public Tuple<int, int> Size { get; }

    /// <summary>
    /// Gets the remaining life points of the Battleship.
    /// </summary>
    public int Life { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Battleship"/> class with a specified size.
    /// </summary>
    /// <param name="size">A tuple representing the height and width of the Battleship.</param>
    public Battleship(Tuple<int, int> size)
    {
        this.Life = size.Item1 * size.Item2;
        this.Size = size;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Battleship"/> class with specified height and width.
    /// </summary>
    /// <param name="height">The height of the Battleship.</param>
    /// <param name="width">The width of the Battleship.</param>
    public Battleship(int height, int width)
    {
        this.Life = height * width;
        this.Size = Tuple.Create(height, width);
    }

    /// <summary>
    /// Updates the remaining life points of the Battleship.
    /// </summary>
    /// <param name="newLife">The new life points to set for the Battleship.</param>
    public void UpdateLife(int newLife)
    {
        this.Life += newLife;
    }
}

}