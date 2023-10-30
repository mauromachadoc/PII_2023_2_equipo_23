
    // Se implementa la clase Gameboard que tiene la exclusiva responsabilidad de conocer el estado de un tablero de la batalla naval en un momento dado.
    // Se satisface de esta manera SRP. La información necesaria para cumplir con esta tarea es la de los Battleships que se encuentran posicionados en cada
    // casillero del tablero así como lo que ha pasado en cada casilla. También Gameboard debe conocer su estado (esto es si el mismo está "vivo" o no)
    
    // Para la estructura en si del GameBoard se hace uso del tipo antes creado Pair, creandose un Array bidimensional de estos que guardarán
    // un int con el estado de esa casilla (tocada, agua o hundida, por ejemplo) junto al Battleship que en esta se encontrase (null en caso de
    // que no hubiese ninguno)
 
    // El parámetro IsBoardAlive devuelve si el tablero se encuentra "vivo", lo cual será falso si y solo si todas las battleships que en el se encuentran
    // se hallan hundidas (con vida igual a 0). Dado que Gameboard almacena tanto la posición de las Battleship como los impactos sobre el tablero. Resulta
    // evidente que debe corresponder a esta clase el contrastar esta información para poder determinar si el tablero en general se encuentra "vivo".
    // (Patrón Expert).


    namespace GBoard
{
    /// <summary>
    /// Represents the state of a naval battle game board at a given moment.
    /// </summary>
    public class Gameboard
    {
        /// <summary>
        /// Gets the list of Battleships present on the game board.
        /// </summary>
        public List<Battleship> Battleships { get; }

        /// <summary>
        /// Gets or sets a 2D array representing the state of each cell on the game board.
        /// Each cell contains an integer indicating its state (e.g., hit(1), water(0)) and the Battleship located there (null if none).
        /// </summary>
        public Pair<int, Battleship>[,] Board { get; }

        private bool _isBoardAlive;

        /// <summary>
        /// Gets a value indicating whether the game board is still "alive."
        /// The board is considered alive if at least one Battleship on it has remaining life points.
        /// </summary>
        public bool IsBoardAlive
        {
            get
            {
                bool _isBoardAlive = true;
                foreach (Battleship battleship in Battleships){
                    if (battleship.Life == 0)
                    {
                        _isBoardAlive = false;
                        break;
                    }
                }
                return _isBoardAlive;
                
            }
            private set{_isBoardAlive = value;}
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Gameboard"/> class.
        /// </summary>
        /// <param name="battleships">The list of Battleships present on the game board.</param>
        /// <param name="size">A tuple representing the size of the game board (number of rows and columns).</param>
        public Gameboard(List<Battleship> battleships, Tuple<int, int> size)
        {
            this.Board = new Pair<int, Battleship>[size.Item1, size.Item2];
            this.Battleships = battleships;
            this.IsBoardAlive = true;
        }
    }

}
