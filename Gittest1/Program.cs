using System;
using System.Data;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}") ;
            Task1();
            
        }

        public static void Task1()
         {
            double radius = Convert.ToDouble(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());
            double pi = Math.PI;

            double volume = pi * Math.Pow(radius, 2) * height;
            Console.WriteLine("Volume:" + volume);
            
        }
        /*Напишите программу определения, попадает ли указанное пользователем число 
         * от 0 до 100 в числовой промежуток [0 - 14] [15 - 35] [36 - 50][50 - 100].
Если да, то укажите, в какой именно промежуток.
Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение.*/

        public static void Task2()
        {
            string numberStr = Console.ReadLine();
            int number = int.Parse(numberStr);

            if (( number >= 0 ) && (number <= 14))
            {
                Console.WriteLine("Число входит в отрезок 0 - 14");
            }
            else if ((number >= 15) && (number <= 35))
            {
                Console.WriteLine("Число входит в отрезок 15 - 35");
            }
            else if ((number >= 36) && (number <= 50))
            {
                Console.WriteLine("Число входит в отрезок 36 - 50");
            }
            else if ((number >= 51) && (number <= 100))
            {
                Console.WriteLine("Число входит в отрезок 51- 100");
            }
            else
            {
                Сonsole.WriteLine("Число не входит в начальные условия");
            }
        }
    }
}
