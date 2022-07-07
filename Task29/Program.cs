// Задача 29: Напишите программу, которая задаёт случайный массив случайного размера (от 5 до 10) элементов 
// (значение элементов от 1 до 40) и выводит на экран массив квадратов этих чисел.

// 1, 2, 5, 7, 19 -> [2, 4, 25, 49, 361]

// 6, 1, 33 -> [36, 1, 1089]

namespace GB
{
    class Task27
    {
        static void Main(string[] args)
        {

            Console.Clear();
            int[] array = new int[new Random().Next(5,11)];
            FillArray(array);
            Console.WriteLine("Случайно сгенерированный массив, ");
            Console.WriteLine("размер от 5 до 10, ");
            Console.WriteLine("значения элементов от 1 до 40:");                  
            PrintArray(array);
            Console.WriteLine("Массив квадратов этих чисел:");
            GetSquare(array);
            PrintArray(array);
           
           
           
           
           
            void FillArray(int[] col) 
            {
                
                for (int i = 0; i < col.Length; i++)
                {
                    col[i] = new Random().Next(1, 41);
                }
            }

            void PrintArray(int[] col)  
            {
                
                for (int i = 0; i < col.Length; i++)
                {
                    Console.WriteLine(col[i]);
                }
            }

            void GetSquare(int[] square)
            {
                for (int i = 0; i < square.Length; i++)
                {
                    square[i] = square[i] * square[i]; 
                }
                
            }
            
        }
    }
}