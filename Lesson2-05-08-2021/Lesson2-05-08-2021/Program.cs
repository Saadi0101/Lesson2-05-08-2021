using System;
namespace Lesson2_05_08_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // ДЗ №1
            System.Console.WriteLine("ДЗ №1");
            System.Console.WriteLine("Ввeдите А");
            int A = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Ввeдите B");
            int B = Convert.ToInt32(Console.ReadLine());
            if (A > B)
            {
                B = A;
                Console.WriteLine($"A={A}, B={A}");
            }
            else if (A < B)
            {
                A = B;
                Console.WriteLine($"A={B}, B={B}");
            }
            else
            {
                A = 0;
                B = 0;
                Console.WriteLine($"A={A}, B={A}");
            }

            // ДЗ №2
            System.Console.WriteLine("ДЗ №2");
            System.Console.WriteLine("Ввeдите А");
            int a = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Ввeдите B");
            int b = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Ввeдите арифметическую операцию");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    {
                        int result = a + b;
                        System.Console.WriteLine($"Результат:{result}");
                    }
                    break;
                case "-":
                    {
                        double result = a - b;
                        System.Console.WriteLine($"Результат:{result}");
                    }
                    break;
                case "*":
                    {
                        double result = a * b;
                        System.Console.WriteLine($"Результат:{result}");
                    }
                    break;
                case "/":
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("Нельзя делить на ноль");
                        }
                        else
                        {
                            double result = a / b;
                            System.Console.WriteLine($"Результат:{result}");
                        }
                    }
                    break;

                default:
                    {
                    }
                    break;
            }
            // ДЗ №3
            Console.WriteLine("ДЗ №3");
            System.Console.WriteLine("Ввeдите число");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k <= 14)
            {
                Console.WriteLine("Ваше число входит в первый промежуток");
            }
            else if (k <= 35) 
            {
                Console.WriteLine("Ваше число входит в второй промежуток");
            }
            else if (k <= 50)
            {
                Console.WriteLine("Ваше число входит в третий промежуток");
            }
            else if (k <= 100)
            {
                Console.WriteLine("Ваше число входит в четвертый промежуток");
            }
            else 
            {
                Console.WriteLine("Ваше число не входит ни в один из имеющихся числовых промежутков"); 
            }
            
        }   
    }
}
