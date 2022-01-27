using Hilo.Game;


namespace hilo
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            Dealer dealer = new Dealer();
            dealer.StartGame();
        }
    }
}
