using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Matches;

namespace Interaction
{
    public class ConsoleLobbyPlayerInteraction : ILobbyPlayerInteraction
    {

        public Tuple<int, int, bool> askForPositioning(Battleship battleship, User user)
        {
            Console.WriteLine($"Elija donde posicionar su nave de {battleship.Size.Item1} x {battleship.Size.Item2}. Ej.: D3");
            string position = Console.ReadLine();
            int positionx = char.Parse(position.Substring(0,1).ToUpper()) - 'A';
            int positiony = int.Parse(position.Substring(1)) - 1;

            Console.WriteLine("Elija si quiere rotar su nave: (S/N)");
            string orientation = Console.ReadLine();
            if (orientation == "S")
            {
                return Tuple.Create(positionx, positiony, false);
            }   else
            {

                return Tuple.Create(positionx, positiony, true);
            }
        }

        public void joinToMatch(Admin admin, User user2)
        {
            Console.WriteLine("Elija una match para conectarse escribiendo su número de ID: ");
            foreach (IMatch matche in admin.Matches)
            {
                if (matche.User2 == null)
                {
                    Console.WriteLine($"Match de {matche.User1.Name}. ID: {matche.MatchID}");
                }
                
            }
            int matchID = Int32.Parse(Console.ReadLine());

            var match = admin.Matches.FirstOrDefault(match => match.MatchID == matchID);
            match.User2 = user2;

            GameSetter.joinMatch(match);
        }


    }
}