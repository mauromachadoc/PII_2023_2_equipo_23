namespace Matches
{
    using General;
    // La clase MatchHandler ejecuta, mediante métodos estáticos, la comunicación con una Match, que era estrictamente un Information Holder.
    // Se tomó la decisión de que estos métodos se encontrasen por separado de la propia clase Match tanto por el hecho de que no requieren depender
    // de una instanciación de esta clase como por la intención de alcanzar una mayor distrubución de responsabilidades entre las clases.
    public interface IMatchHandler
    {
    
        public static void RunTurn(IMatch match, IPrinter printer)
        {
    
        }

        public static void EndMatch(IMatch match)
        {
            match.MatchStatus = "f";
        }

        public static void SetMatch(GameSettings settings, Admin admin, User user)
        {
            
        }
    }
}