using Tyuiu.ErmakovAA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ErmakovAA.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            // вызываем класс DataService и метод GetMassege
            // из библиотеки Tyuiu.ErmakovAA.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMassege("Александр"));
            Console.ReadKey();
    
        }
    }
}
