﻿using System;


// Демонстрация работы алгоритмов на языке C#.
namespace Algorithms
{
    class Program
    {
        static void Main()
        {
            // Программа, демонстрирующая применение алгоритма "Бинарный поиск". 
            //int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] arr3 = { 1, 3, 4, 5, 10, 17, 18 };
            //int[] arr4 = { -5, -4, -2, 0, 1, 3, 5, 7 };

            //BinarySearchClass ob1 = new BinarySearchClass();
            //Console.WriteLine(ob1.BinarySearch(-5, arr4, out int count) + " " + count);


            //// Программа, демонстрирующая работу алгоритма "Сортировка выбором".
            //int[] arr5 = { 0, 15, -27, 4, 98, -100 };

            //SelectionSort ob2 = new SelectionSort();
            //int[] newArr = ob2.Sort(arr5);
            //ob2.PrintArr(newArr);
            //ob2.PrintArr(arr5);

            // Программа, демонстрирующая работу алгоритма рекурсии.
            //Recursion ob3 = new Recursion();
            //Console.WriteLine(ob3.Fact(5));

            // Программа, демонстрирующая базовую работу стека.
            Stack ob1 = new Stack(5);   // создание экземпляра класса

            // Заполнение стек значениями.
            for (int i = 0, j = 10; i < ob1.arr.Length; i++, j *= 2)
            {
                ob1.Push(j);
            }
            Console.WriteLine();
            Console.WriteLine($"Количество элементо в стеке: {ob1.Count()}");

            // Попытка вставить значение в заполненный стек.
            ob1.Push(15);

            Console.Write("Значения из стека: ");
            // Выборка значений из стека.
            for (int i = 0; i < ob1.arr.Length; i++)
            {
                Console.Write($"{ob1.Pop()} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Количество элементо в стеке: {ob1.Count()}");

            // Попытка взять значение из пустого стека.
            ob1.Pop();
        }
    }
}

