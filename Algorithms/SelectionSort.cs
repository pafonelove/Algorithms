using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


// Алгоритм сортировки выбором.
// Максимальное время выполнения - O(n^2), где n - количество операций сортировки.
namespace Algorithms
{
    internal class SelectionSort
    {
        public int[] Sort(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            int tmp;

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            for (int i = 0; i < newArr.Length - 1; i++)
            {
                for (int j = i + 1; j < newArr.Length; j++)
                {
                    if (newArr[j] < newArr[i])
                    {
                        tmp = newArr[i];
                        newArr[i] = newArr[j];
                        newArr[j] = tmp;
                    }
                }
            }

            return newArr;
        }

        public void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}