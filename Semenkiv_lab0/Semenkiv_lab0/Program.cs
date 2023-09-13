using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Semenkiv_lab0
{
    internal class Program
    {
        /// <summary>
        /// Возведения в квадрат разности двух целых чисел
        /// </summary>
        /// <param name="number1"> Первое целое число</param>
        /// <param name="number2">Второе целое число</param>
        /// <returns> квадрат разности двух целых чисел</returns>
        private static int SquaringDiferenceOfTwoIntegers(int squaring)
        {
            return squaring;

        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number1 = rnd.Next(-100, 100);
            int number2 = rnd.Next(-100, 100);
            int diference = number1-number2;
            int squaring = (int) Math.Pow(diference, 2);
            Console.WriteLine("Вариант 11 : Реализовать функцию возведения в квадрат разности двух целых чисел ");
            Console.WriteLine($" \n Первое число:{number1} ; Второе число:{number2} ; \n \n Квадрат разницы целых чисел: {SquaringDiferenceOfTwoIntegers(squaring)}");
            Console.ReadLine();
        }
    }
}