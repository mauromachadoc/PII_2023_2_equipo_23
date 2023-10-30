namespace Matches
{
    using GBoard;

    /*
        Clase donde se guardan los settings de una partida. Esta tiene como única responsabilidad 
        guardar la información necesaria para crear un match (SRP), como el tamaño de la gameboard y las 
        battleships que cada user tendrá a disposición, que cumple el patrón expert.
    */

    /// <summary>
    /// Represents the settings, including the board size and playable battleships.
    /// </summary>
    public class GameSettings
    {
        /// <summary>
        /// Gets the size of the game board as a tuple (rows, columns).
        /// </summary>
        public Tuple<int, int> Size { get; }

        /// <summary>
        /// Gets the list of playable battleships
        /// </summary>
        public List<Battleship> PlayableBattleships { get; }

        /// <summary>
        /// Initializes a new instance of the GameSettings class.
        /// </summary>
        /// <param name="size">The size of the game board as a tuple (rows, columns).</param>
        /// <param name="playableBattleships">The list of playable battleships.</param>
        public GameSettings(Tuple<int, int> size = null, List<Battleship> playableBattleships = null)
        {
            if (playableBattleships == null)
            {
                this.PlayableBattleships = DefaultBattleshipSetup();
            }
            else
            {
                this.PlayableBattleships = playableBattleships;
            }

            if (size == null)
            {
                this.Size = new Tuple<int, int>(5, 5);
            }
            else
            {
                this.Size = size;
            }
        }

        /// <summary>
        /// Generates the default setup of playable battleships.
        /// </summary>
        /// <returns>The list of default playable battleships.</returns>
        private List<Battleship> DefaultBattleshipSetup()
        {
            List<Battleship> playableBattleships = new List<Battleship>();
            Battleship b1 = new Battleship(3, 1);
            playableBattleships.Add(b1);
            Battleship b2 = new Battleship(2, 2);
            playableBattleships.Add(b2);
            Battleship b3 = new Battleship(1, 1);
            playableBattleships.Add(b3);
            Battleship b4 = new Battleship(1, 2);
            playableBattleships.Add(b4);
            Battleship b5 = new Battleship(2, 1);
            playableBattleships.Add(b5);

            return playableBattleships;
        }
    }
}
