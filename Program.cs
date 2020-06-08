using System;

namespace GolfSimple
{
    class Program
    {
        static void Main(string[] args)
        {
//            Player player1 = new Player("Harvey", ClubType.GRAPHITE, BallType.MAXFLI, GloveType.CALLOWAY);
//            Player player2 = new Player("Penick", ClubType.STEEL, BallType.SRIXON, GloveType.FOOTJOY);

            Player player1 = new Player("Harvey", new GolfBagAggressive());
            Player player2 = new Player("Penick", new GolfBagAmateur());
            Player player3 = new Player("Mickelson", new GolfBagWeekender());

//            Caddy caddy = new Caddy("Bones", player1, player2);

            // Need to set the course in caddy - perhaps from args.
            // Need to set the scoring method in caddy = perhaps from args.

//           Console.WriteLine(caddy.ToString());

            // Simulate the game.
//            caddy.Game();

            Console.WriteLine(player1.ToString());
            Console.WriteLine(player2.ToString());
            Console.WriteLine(player3.ToString());

        }
    }
}
