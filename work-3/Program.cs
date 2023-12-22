// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 



class Program
{
    static void Main()
    {
        Console.WriteLine("Введите размер массива:");
        int num = int.Parse(Console.ReadLine());

        int[] array = new int[num];
        int[] array2 = new int[num];

        ArrayRandomValues(array, 0);
        Console.Write($"[{string.Join(" ", array)}] => ");
        ReverseArray(array, array2, 0);
        Console.Write($"{string.Join(" ", array2)}");
    }
    static void ArrayRandomValues(int[] arr, int index)
    {
        if (index < arr.Length)
        {
            arr[index] = new Random().Next(0, 15);
            ArrayRandomValues(arr, index + 1);
        }
    }
    static void ReverseArray(int[] original, int[] reversed, int index)
    {
        if (index < original.Length)
        {
            reversed[index] = original[original.Length - 1 - index];
            ReverseArray(original, reversed, index + 1);
        }
    }
}
