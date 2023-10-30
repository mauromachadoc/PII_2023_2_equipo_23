// clase adelantada Y EN DESARROLLO

namespace Matches
{

    public class GameSetter
    {

        public static void PositionBattleship(Tuple<int, int> battleshipPosition, int x, Gameboard gameboard, bool rotated = false)
        {
            Battleship battleship = gameboard.Battleships[x];

            if (rotated == false)
            {
                for (int i = 0; i < battleship.Size.Item1; i++)
                {
                    for (int j = 0; j < battleship.Size.Item2; i++)
                    {
                        gameboard.Board[i + battleshipPosition.Item1, j + battleshipPosition.Item2].Second = battleship;
                    }
                }
            }   else
            {
               for (int i = 0; i < battleship.Size.Item1; i++)
                {
                    for (int j = 0; j < battleship.Size.Item2; i++)
                    {
                        gameboard.Board[j + battleshipPosition.Item1, i + battleshipPosition.Item2].Second = battleship;
                    }
                } 
            }


        }

        public static Match initializeMatch(GameSettings gameSettings, User user1)
        {
            Gameboard gameboard1 = new Gameboard(gameSettings.PlayableBattleships, gameSettings.Size);
            Gameboard gameboard2 = new Gameboard(gameSettings.PlayableBattleships, gameSettings.Size);

            for (int k = 0; k < gameboard1.Battleships.Count; k++)
            {
                Tuple <int, int, bool> positioning = user1.LobbyPlayerInteraction.askForPositioning(gameboard1.Battleships[k], user1);
                PositionBattleship(Tuple.Create(positioning.Item1, positioning.Item2), k, gameboard1, positioning.Item3);
            }



            return new Match(gameboard1, gameboard2, user1);

        }

        public static void joinMatch(IMatch match)
        {
            for (int k = 0; k < match.User2Gameboard.Battleships.Count; k++)
            {
                Tuple <int, int, bool> positioning = match.User2.LobbyPlayerInteraction.askForPositioning(match.User2Gameboard.Battleships[k], match.User2);
                PositionBattleship(Tuple.Create(positioning.Item1, positioning.Item2), k, match.User2Gameboard, positioning.Item3);
            }
        }

    }
}