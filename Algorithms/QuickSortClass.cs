using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Алгоритм бинарного поиска.
// Максимальное количество проверок в нем = n * log(2)n, где n - количество операций для сортировки.
namespace Algorithms
{
    internal class QuickSortClass
    {
        public int[] QuickSort(int[] arr, int start, int end) {
            if (start >= end)
                return arr;
            
            int pivot = GetPivot(arr, start, end);

            QuickSort(arr, start, pivot - 1);   // сортировка подмассива, находящегося слева от опорного элемента (числа < pivot).
            QuickSort(arr, pivot + 1, end);     // сортировка подмассива, находящегося справа от опорного элемента (числа > pivot).

            return arr;
        }

        // Получение опорного элемента.
        public int GetPivot(int[] arr, int start, int end)
        {
            int pivot = start - 1;

            for (int i = start; i <= end; i++)
            {
                if (arr[i] < arr[end])
                {
                    pivot++;
                    Swap(ref arr[pivot], ref arr[i]);
                }
            }

            pivot++;
            Swap(ref arr[pivot], ref arr[end]);

            return pivot;
        }

        // Метод перестановки чисел между собой.
        public void Swap(ref int left, ref int right)   // параметры передаются по ссылке, чтобы изменить их в самом массиве
        {
            int tmp = left;
            left = right;
            right = tmp;
        }
    }
}
