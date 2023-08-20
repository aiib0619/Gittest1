using System;
using System.Data;
using System.Data.SqlTypes;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Task1();
            Task2();
            Task3();
            Task4();
        }

        public static void Task1()
        {
            Console.Write("Первое число ");
            string input1 = Console.ReadLine();
            int operand1 = Int32.Parse(input1);
            Console.Write("Второе число число ");
            string input2 = Console.ReadLine();
            int operand2 = Int32.Parse(input2);
            Console.Write("Знак операции ");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    {
                        Console.WriteLine(operand1 + operand2);
                        break;
                    }

                case "-":
                    {
                        Console.WriteLine(operand1 - operand2);
                        break;
                    }

                case "*":
                    {
                        Console.WriteLine(operand1 * operand2);
                        break;
                    }

                case "/":
                    {
                        try
                        {
                            Console.WriteLine(operand1 / operand2);
                        }
                        catch (DivideByZeroException)
                        { Console.WriteLine("Деление на 0!"); }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Некорректный знак");
                        break;
                    }

            }
            

        }
    
        public static void Task2()
        {
            Console.Write("Введите число ");
            string numberStr = Console.ReadLine();
            
            int number = int.Parse(numberStr);

            if ((number >= 0) && (number <= 14))
            {
                Console.WriteLine("Number in 0 - 14");
                return;
            }
            else if ((number >= 15) && (number <= 35))
            {
                Console.WriteLine("Number in 15 - 35");
                return;
            }
            else if ((number >= 36) && (number <= 50))
            {
                Console.WriteLine("Number in 36 - 50");
                return;
            }
            else if ((number >= 51) && (number <= 100))
            {
                Console.WriteLine("Number in 51- 100");
                return;
            }
            else
            {
                Console.WriteLine("Number error");
                
            }
        }
        public static void Task3()
        /*Напишите программу русско-английский переводчик.
        Программа знает 10 слов о погоде.
        Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на английском языке.
        Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение, что такого слова нет.
        */

        {
            {
                Console.Write("Введите слово ");
                String input = Console.ReadLine();
                String Weather = input.ToLower();
                

                if (Weather == "жарко")
                {
                    Console.WriteLine("Hot");
                    return;
                }
                else if (Weather == "тепло")
                {
                    Console.WriteLine("Warm");
                    return;
                }
                else if (Weather == "холодно")
                {
                    Console.WriteLine("Cold");
                    return;
                }
                else if (Weather == "солнечно")
                {
                    Console.WriteLine("Sunny");
                    return;
                }
                else if (Weather == "пасмурно")
                {
                    Console.WriteLine("Cloudy");
                    return;
                }
                else if (Weather == "дождливо")
                {
                    Console.WriteLine("Raining");
                    return;
                }
                else if (Weather == "ветрено")
                {
                    Console.WriteLine("Windy");
                    return;
                }
                else if (Weather == "мрачно")
                {
                    Console.WriteLine("Gloomy");
                    return;
                }
                else if (Weather == "ярко")
                {
                    Console.WriteLine("Bright");
                    return;
                }
                else if (Weather == "безоблачно")
                {
                    Console.WriteLine("Clear");
                    return;
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
        public static void Task4()
        /*Напишите программу, которая будет выполнять проверку чисел на четность.
        */

        {
            Console.Write("Введите число ");
            int number3= int.Parse(Console.ReadLine());

            if ((number3 % 2) == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
        }
    }
}