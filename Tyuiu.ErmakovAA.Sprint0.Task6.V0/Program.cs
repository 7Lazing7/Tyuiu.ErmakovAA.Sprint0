﻿using Tyuiu.ErmakovAA.Sprint0.Task6.V0.Lib;
namespace Tyuiu.ErmakovAA.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numsArray));

            Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(numsArray));

            Console.WriteLine("Произведение элементов массива = " + DataService.MultArray(numsArray));

            Console.ReadKey();
        }
    }
}