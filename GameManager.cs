using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_injection
{
    
    public class GameManager
    {
        private IPlayer _player1;
        private IPlayer _player2;

        public GameManager(IPlayer player1, IPlayer player2) 
        {
            _player1 = player1;
            _player2 = player2;
        }


        public RoundResult PlayRound()
        {

            Choice p1 = _player1.GetChoice();

            Choice p2 = _player2.GetChoice();


            Console.WriteLine($"Player 1 picks {p1.ToString()} And Computer picks {p2.ToString()}");
            if (p1 == p2)
            {
                return RoundResult.Draw;
            }

            if (p1 == Choice.Rock && p2 == Choice.Scissor ||
                p1 == Choice.Paper && p2 == Choice.Rock ||
                p1 == Choice.Scissor && p2 == Choice.Paper)
            {
                return RoundResult.Play1Win;
            }

            return RoundResult.Play2Win;
        }
    }

    public enum Choice
    {
        Rock,
        Paper,
        Scissor
    }

    public enum RoundResult
    {
        Play1Win,
        Play2Win,
        Draw
    }
}
