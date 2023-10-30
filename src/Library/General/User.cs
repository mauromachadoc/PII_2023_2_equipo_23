namespace General
{
    /*
        Clase que representa a un usuario. Esta sigue el patrón SRP y expert ya que tiene la información
        vital para su única responsabilidad, como el nombre de usuario y su ID.
    */

    /// <summary>
    /// Represents a user in the system with a name and an ID.
    /// </summary>
    public class User
    {
        private string _name;
        /// <summary>
        /// Gets the name of the user.
        /// </summary>
        /// 

        public string Name
        {
            get
            {
                return _name;
            }
            internal set
            {
                if (String.IsNullOrEmpty(value))
                    _name = "undefined";
                else _name = value;
            }
        }

        /// <summary>
        /// Gets the unique identifier of the user.
        /// </summary>
        public int Id { get; }


        public ILobbyPlayerInteraction LobbyPlayerInteraction { get;}


        public IInGamePlayerInteraction InGamePlayerInteraction { get;}

        /// <summary>
        /// Initializes a new instance of the User class with the specified name.
        /// </summary>
        /// <param name="name">The name of the user. If empty then name is set to "undefined"</param>
        public User(string name)
        {
            this.Name = name;
            Random rand = new Random();
            this.Id = rand.Next(100000, 1000000);
        }
    }
}
