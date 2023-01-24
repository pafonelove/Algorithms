using System;


// Демонстрация работы стека.
namespace Algorithms {
    class Stack {
        public int[] arr;   // массив чисел (стек)
        int tos;            // позиция в стеке
        
        // Создание объекта Stack.
        public Stack(int size) {
            arr = new int [size];   // выделение памяти под стек
            tos = 0;
        }

        // Если стек пустой.
        public bool IsEmpty() {
            if (tos == 0) 
                Console.WriteLine("Stack is empty!");

            return (tos == 0);
        }

        // Если стек заполнен.
        public bool IsFull() {
            if (tos == arr.Length)
                Console.WriteLine("Stack is full!");

            return (tos == arr.Length);
        }

        // Добавить в стек.
        public void Push(int n) {
            if (IsFull())
                return;

            arr[tos] = n;
            tos++;
        }

        // Взять из стека.
        public int Pop() {
            int n = 0;

            if (IsEmpty())
                return 0;
            
            tos--;
            return n = arr[tos];
        }

        // Количество находящихся в стеке элементов.
        public int Count() {
            return tos;
        }
    }
}