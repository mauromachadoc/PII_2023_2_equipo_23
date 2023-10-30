namespace Matches;

    using General;
    // La clase MatchHandler ejecuta, mediante métodos estáticos, la comunicación con una Match, que era estrictamente un Information Holder.
    // Se tomó la decisión de que estos métodos se encontrasen por separado de la propia clase Match tanto por el hecho de que no requieren depender
    // de una instanciación de esta clase como por la intención de alcanzar una mayor distrubución de responsabilidades entre las clases.
    public class ConsoleMatchHandler : IMatchHandler
    {

        public static void RunTurn(IMatch match)
        {
            switch (match.MatchStatus) 
            {
                case "tu1":
                    match.User1.InGamePlayerInteraction.askForPlayOverGameboard(match.User2Gameboard);
                    if (match.MatchStatus != "wi1" && match.MatchStatus != "wi2") {match.MatchStatus = "tu2";};
                    break;

                case "tu2":
                    match.User2.InGamePlayerInteraction.askForPlayOverGameboard(match.User1Gameboard);
                    if (match.MatchStatus != "wi1" && match.MatchStatus != "wi2") {match.MatchStatus = "tu1";};
                    break;

                case "wi1" or "wi2":
                    match.User1.InGamePlayerInteraction.reportGameStatus(match);
                    match.User2.InGamePlayerInteraction.reportGameStatus(match);
                    ConsoleMatchHandler.EndMatch(match);
                    break;
            }
        }

        public static void EndMatch(IMatch match)
        {
            match.MatchStatus = "f";
        }

        public static void SetMatch(GameSettings settings, Admin admin, User user)
        {
            admin.Matches.Add(GameSetter.initializeMatch(settings, user));
        }
    }
