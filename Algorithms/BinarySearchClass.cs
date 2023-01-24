using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Алгоритм бинарного поиска.
// Максимальное количество проверок в нем = log(2)n, где n - количество операций для поиска числа (количество элементов в массиве).
namespace Algorithms
{
    internal class BinarySearchClass
    {
        public int BinarySearch(int item, int[] arr, out int count)
        {
            int low = 0;                // первый элемент массива - левая граница бинарного поиска
            int high = arr.Length - 1;  // последний элемент масива - правая граница бинарного поиска
            int mid;                    // средний элемент массива, от которого начинается поиск нужного элемента
            int guess;                  // входящий элемент бинарного поиска
            count = 0;                  // количество шагов для поиска нужного элемента

            while (low <= high)
            {
                mid = (low + high) / 2;     // вычисление середины диапазона бинарного поиска
                Console.WriteLine(mid);
                guess = arr[mid];
                count++;
                if (guess == item)
                {
                    return mid;             // если входящий элемент равен нужному, возвращаем индекс элемента в массиве
                }
                else if (guess > item)
                {
                    high = mid--;           // если входящий элемент больше нужного, сокращаем область бинарного поиска
                }
                else if (guess < item)
                {
                    low = mid++;            // если входящий элемент меньше нужного, сокращаем область бинарного поиска
                }
                else
                {
                    return 0;
                }
            }
            return 0; // иначе возвращаем 0, если элемент отсутствует
        }
    }
}
