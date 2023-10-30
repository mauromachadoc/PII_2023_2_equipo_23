namespace General;

using Matches;

/*
    Clase que representa a el administrador de las partidas. Esta clase tiene la responsabilidad de guardar la información
    de las partidas creadas para así unirse o crear una nueva, lo que hace que cumpla con el patrón SRP. También cumple con
    expert ya que tiene solo la información relevante para esta.
*/

/// <summary>
/// Represents an administrator with access to matches, users, and game settings.
/// </summary>
public class Admin
{
    /// <summary>
    /// Gets the list of matches.
    /// </summary>
    public List<IMatch> Matches;

    /// <summary>
    /// Gets or sets the list of users available through the Telegram API.
    /// </summary>
    public List<User> Users;

    // Uncomment if needed
    // public LobbyPlayerInteraction LobbyInteractionContext;

    /// <summary>
    /// Connects the administrator to the specified match.
    /// </summary>
    /// <param name="match">The match to connect to.</param>
    public void ConnectToMatch(IMatch match)
    {
        // Implementation details go here
    }

    /// <summary>
    /// Creates a new match with the specified game settings.
    /// </summary>
    /// <param name="gameSettings">The game settings for the new match.</param>
    /// <returns>The created match.</returns>
    public void CreateMatch(GameSettings gameSettings, User user)
    {
        this.Matches.Add(GameSetter.initializeMatch(gameSettings, user));

    }

    /// <summary>
    /// Initializes a new instance of the Admin class.
    /// </summary>
    /// <param name="myUser">The user associated with the administrator.</param>
    
    public void AddUser(string name)
    {
        this.Users.Add(new User(name));
    }
    public Admin()
    {
        this.Users = new List<User>();
        this.Matches = new List<IMatch>();
    }
}
