//Anna Söderberg SUT23

namespace OOP_Labb_1___Grunderna_i_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle area1 = new(5);
            Circle area2 = new(6);

            Console.WriteLine($"Arean för cirkel 1 är {area1.getArea()}.");
            Console.WriteLine($"Omkretsen för cirkel 1 är {area1.getCircumference()}.");
            Console.WriteLine($"volymen för cirkel 1 är {area1.getVolume()}.");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Arean för cirkel 2 är {area2.getArea()}.");
            Console.WriteLine($"Omkretsen för cirkel 2 är {area2.getCircumference()}.");
            Console.WriteLine($"volymen för cirkel 2 är {area2.getVolume()}.");

        }
    }
}