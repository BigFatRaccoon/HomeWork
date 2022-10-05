// Задача 34:
// 1. Задайте массив, заполненный случайными положительными трёхзначными числами.
// 2. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (i < length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.WriteLine("]");
}

int CounterOfEvenDigits(int[] array)
{
    int length = array.Length;
    int counter = default;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0) counter++;
    }
    return counter;
}

int[] newArray = CreateArrayRndInt(5, 100, 999);
PrintArray(newArray);
int counterOfEvenDigits = CounterOfEvenDigits(newArray);
Console.WriteLine(counterOfEvenDigits);