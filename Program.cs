namespace chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Board.flipBitboard(0x000000000000FF00).ToString("X"));
        }
    }
}
