using CardGame.Services;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GameService service = new GameService();
            service.Run();
        }
    }
}
