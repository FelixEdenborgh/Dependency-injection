using Dependency_injection;

public class Program
{
    // https://www.youtube.com/watch?v=cCSrPZroICg
    private static void Main(string[] args)
    {
        GameManager gm = new GameManager(new HumanPlayer(), new ComputerPlayer());

        do
        {
            RoundResult result = gm.PlayRound();

            if (result == RoundResult.Play1Win)
            {
                Console.WriteLine("Player 1 Wins!");
            }
            else if (result == RoundResult.Play2Win)
            {
                Console.WriteLine("Player 2 Wins!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }

            Console.Write("Play Again (Y/N)? ");
        } while (Console.ReadLine().ToUpper() == "Y");
    }
}