using Repository;
using System;

namespace RPSConsole
{
    public class ProgramUI
    {
        public void Run()
        {
            Console.WriteLine("Player 1 enter your move, Player 2 dont look\n1.Rock\n2.Scissors\n3.Paper");
            var p1input = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Player 2 enter your move, Player 1 dont look\n1.Rock\n2.Scissors\n3.Paper");
            var p2input = Console.ReadLine();

            RockPaperScissorsRepo repo = new RockPaperScissorsRepo();

            switch (int.Parse(p1input))
            {
                case 1:
                    var rock = Move.Rock;
                    repo.SetMove(rock);
                    break;
                case 2:
                    var paper = Move.Paper;
                    repo.SetMove(paper);
                    break;
                case 3:
                    var scissors = Move.Scissors;
                    repo.SetMove(scissors);
                    break;
            }

            switch (int.Parse(p2input))
            {
                case 1:
                    var rock = Move.Rock;
                    repo.SetMove(rock);
                    break;
                case 2:
                    var paper = Move.Paper;
                    repo.SetMove(paper);
                    break;
                case 3:
                    var scissors = Move.Scissors;
                    repo.SetMove(scissors);
                    break;
            }

            var moves = repo.GetMoves();

            foreach (var m in moves)
            {
                Console.WriteLine("Player " + m.ToString());
            }

            Console.ReadKey();
        }
    }

}
