// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

namespace GB
{
    class Task27
    {
        static void Main(string[] args)
        {
        
            Console.Clear();
            Console.WriteLine("Введите число:");
            string a = Convert.ToString(Console.ReadLine());
            int result = Sum(a);
            // for (int i = 0; i < a.Length; i++)
            // {
            //     result = result + Convert.ToInt32(a[i].ToString());
            // }
            Console.WriteLine(result);
            
        }
        static int Sum(string a)
        {
            int result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                result = result + Convert.ToInt32(a[i].ToString());
            }
            
            return result;
        }  
    }
}