using System;

namespace Algorithms {
    class MyClass {
        static void Main() {
            // Программа, демонстрирующая базовую работу стека.
            Stack ob1 = new Stack(5);   // создание экземпляра класса
            
            // Заполнение стек значениями.
            for (int i = 0, j = 10; i < ob1.arr.Length; i++, j*=2) {
                ob1.Push(j);
            }
            Console.WriteLine();
            Console.WriteLine($"Количество элементо в стеке: {ob1.Count()}");

            // Попытка вставить значение в заполненный стек.
            ob1.Push(15);

            Console.Write("Значения из стека: ");
            // Выборка значений из стека.
            for (int i = 0; i < ob1.arr.Length; i++) {
                Console.Write($"{ob1.Pop()} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Количество элементо в стеке: {ob1.Count()}");

            // Попытка взять значение из пустого стека.
            ob1.Pop();
        }
    }
}