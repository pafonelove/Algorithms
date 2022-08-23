// Программа, демонстрирующая применение алгоритма "Бинарный поиск". Максимальное количество проверок в нем = log(2)n, где n - количество операций для поиска числа (количество элементов в массиве).
int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] arr3 = { 1, 3, 4, 5, 10, 17, 18 };
int[] arr4 = { -5, -4, -2, 0, 1, 3, 5, 7 };
//Console.WriteLine(BinarySearch(-5, arr4, out int count) + " " + count);

static int BinarySearch(int item, int[] arr, out int count)
{
    int low = 0;    // первый элемент массива - левая граница бинарного поиска
    int high = arr.Length - 1;  // последний элемент масива - правая граница бинарного поиска
    int mid;    // средний элемент массива, от которого начинается поиск нужного элемента
    int guess;  // входящий элемент бинарного поиска
    count = 0;  // количество шагов для поиска нужного элемента

    while (low <= high)
    {
        mid = (low + high) / 2;     // вычисление середины диапазона бинарного поиска
        Console.WriteLine(mid);
        guess = arr[mid];
        count++; 
        if (guess == item) 
        {
            return mid;             // если входящий элемент равен нужному, возвращаем индекс элемента в массиве
        } else if (guess > item)    
        {
            high = mid--;           // если входящий элемент больше нужного, сокращаем область бинарного поиска
        } else if (guess < item)
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


// Программа, демонстрирующая работу алгоритма "Сортировка выбором".
int[] arr = { 0, 2, -3, 5, -10, 15, 22, 6 };
Console.WriteLine("Before: ");
PrintArr(arr);
Console.WriteLine();

SelectionSort(arr);
Console.WriteLine("After: ");
PrintArr(arr);
Console.WriteLine();

static int[] SelectionSort(int[] arr)
{
    int tmp = 0;

    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[i])
            {
                tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
            }
        }
    }

    return arr;
}

static void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}