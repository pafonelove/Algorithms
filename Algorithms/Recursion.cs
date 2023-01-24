using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Алгоритм рекурсии.
namespace Algorithms
{
    internal class Recursion
    {
        // Пример - вычисление факториала.
        public int Fact(int n)
        {
            if (n == 0)
                return 1;           // базовый случай
            return n * Fact(n - 1); // рекурсивный случай
        }
    }
}
