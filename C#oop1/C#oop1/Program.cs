using System.Drawing;

namespace C_oop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Hello, World!");
            car bmw = new car();
            bmw.Start();
            bmw.color = Color.Red;
            Console.WriteLine(bmw.color);
            bmw.Speed();

            car audi = new car();
            audi.Start();
            audi.Speed();
        }
    }
}