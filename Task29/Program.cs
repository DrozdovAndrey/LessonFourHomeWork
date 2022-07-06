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
            int[] array = new int[new Random().Next(5,10)];
            FillArray(array);
            PrintArray(array);
           
           
           
           
           
            void FillArray(int[] collection) // функция заполнения массива
            {
                int length = collection.Length;
                int index = 0;
                while (index < length)
                {
                    collection[index] = new Random().Next(1, 40);  // рендомными значениями от 1 до 9
                    index++;
                }
            }

            void PrintArray(int[] col)  
            {
                int count = col.Length;
                int position = 0;
                while (position < count)
                {
                    Console.WriteLine(col[position]);
                    position++;
                }
            }
            
        }
    }
}