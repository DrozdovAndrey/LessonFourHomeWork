// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

namespace GB
{
    class Task25
    {
        static void Main(string[] args)
        {
        
            Console.Clear();
            Console.WriteLine("Введите число любое число A:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите натуральное число B:");
            int b = Convert.ToInt32(Console.ReadLine());

            double result = Pow(a, b);
            // for (int i = 1; i <= b; i++)
            // {
            //     result = result * a;
            // }
            Console.WriteLine(result);
        }
        static double Pow(double x, int y)
        {
            double result = 1;
            for (int i = 1; i <= y; i++)
            {
                result = result * x;
            }
            return result;
        }  
    }
}