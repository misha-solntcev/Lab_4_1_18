using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  18. Задан одномерный массив A[1..20]. Просуммировать 
    все отрицательные элементы, стоящие на нечетных местах.*/

namespace Lab_4_1_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем массив и заполняем его случайными числами
            int[] arr = new int[20];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-10, 10);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
            
            // Классический способ
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)            
                if (arr[i] < 0 && i%2 != 0)
                    sum += arr[i];
            Console.WriteLine($"sum = {sum}");
            
            // Расширение Linq
            var res = arr.Where((x, i) => (x < 0) && (i % 2 != 0)).Sum();
            Console.WriteLine($"result = {res}");

            Console.ReadKey();
        }
    }
}
