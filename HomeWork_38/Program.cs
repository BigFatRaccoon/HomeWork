// Задача 38:
// 1. Задайте массив вещественных чисел.
// 2. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, double min, double max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
    }
    return array;
}

void PrintArray(double[] array)
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

double DiffernceBetweenMaxMinDigits(double[] array)
{
    int length = array.Length;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    for (int i = 0; i < length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    double diff = Math.Round((max - min), 1);
    return diff;
}

double[] createArrayRndInt = CreateArrayRndInt(5, 0, 100);
PrintArray(createArrayRndInt);
double differnceBetweenMaxMinDigits = DiffernceBetweenMaxMinDigits(createArrayRndInt);
Console.WriteLine(differnceBetweenMaxMinDigits);