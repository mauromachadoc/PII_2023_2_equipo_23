// Se crea la interfaz IMatch para cumplir con DIP 

namespace Matches
{
    using GBoard;
    using General;
    using Interaction;

    /*
        Clase que representa una match entre dos usuarios. Esta sigue el patrón expert ya que tiene como 
        única responsabilidad el representar una match (SRP), por lo que cuenta con la información
        vital como los settings, los gameboards, los usuarios y el estado del juego, que refiere
        a si el juego ha finalizado o a qué jugador le toca. 
    */

    /// <summary>
    /// Represents a match between two users.
    /// </summary>
    public interface IMatch
    {

        /// <summary>
        /// Gets or sets the gameboard for the first user.
        /// </summary>
        public Gameboard User1Gameboard{get;}

        /// <summary>
        /// Gets or sets the gameboard for the second user.
        /// </summary>
        public Gameboard? User2Gameboard{get;}

        /// <summary>
        /// Gets the first user participating in the match.
        /// </summary>
        public User User1 { get; }

        /// <summary>
        /// Gets the second user participating in the match.
        /// </summary>
        public User? User2 { get; set;}

        /// <summary>
        /// Gets the ID assigned to the match
        /// </summary>
        public int MatchID { get; }

        /// <summary>
        /// Match status indica el estado en el que se encuentra la partida según el siguiente código:
        /// "str" : la match ha sido inicializada y el primer jugador ha posicionado sus barcos
        /// "tu1" : es turno del jugador numero 1 (el que inicio la partida)
        /// "tu2" : es turno del jugador numero 2
        /// "wi1" : la partida ha terminado por haber ganado el jugador 1
        /// "wi2" : la partida ha terminado por haber ganado el jugador 2
        /// </summary>
        public string MatchStatus { get; set; }

        /// <summary>
        /// Gets or sets the context for in-game player interaction.
        /// </summary>

        /// <summary>
        /// Initializes a new instance of the Match class.
        /// </summary>
        /// <param name="user1Gameboard">The gameboard for user 1.</param>
        /// <param name="user2Gameboard">The gameboard for user 2.</param>
        /// <param name="user1">The first user participating in the match.</param>
        /// <param name="inGamePlayerInteractionContext">The context for in-game player interaction</param>
    }
}
