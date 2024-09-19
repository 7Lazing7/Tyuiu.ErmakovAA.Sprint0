using Tyuiu.ErmakovAA.Sprint0.Task4.V0.Lib;
namespace Tyuiu.ErmakovAA.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // пример линейной структуры программы 
            //вызов метода сложения Addition
            Console.WriteLine(DataService.Addition(1, 5));

            Console.WriteLine(DataService.Subtraction(7, 5));

            Console.WriteLine(DataService.Multiplication(7, 7));

            Console.WriteLine(DataService.Division(50, 5));

            Console.ReadKey();
        }
    }
}
