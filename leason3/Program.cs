using leason3.Moduls;
using System.Text;

namespace leason3
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Actor actor = new Actor("Tom Holland", 35, "Spider-Man");

            Director director = new Director("Christopher Nolan", 55, "film raghac");

            Producer producer = new Producer("vighac raghac", 53, "Marvel Studio");

            actor.ShowInfo();

            Console.WriteLine();

            director.ShowInfo();

            Console.WriteLine();

            producer.ShowInfo();
        }
    }
}
