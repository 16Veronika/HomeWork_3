// 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.


class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение M:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        int n = int.Parse(Console.ReadLine());
        Console.Write($"M = {m} ; N = {n} -> ");
        PrintNaturalNumbersInRange(m, n);

    }

    static void PrintNaturalNumbersInRange(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m);
            
            if (m < n)
            {
                Console.Write(", ");
            }
            
            PrintNaturalNumbersInRange(m + 1, n);
        }
    }
}

