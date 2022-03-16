using maniaf;

namespace Maniaf
{
    public static class Program
    {
        static void Main(string[] args)
        {
            using (maniafgame game = new maniafgame())
            {
                game.Run();
            }
        }
    }
}