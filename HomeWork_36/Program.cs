// Задача 36: 
// 1.Задайте одномерный массив, заполненный случайными числами.
// 2. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumOfDigitsOnOddPosition(int[] array)
{
    int length = array.Length;
    int sum = default;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 == 1)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] newArray = CreateArrayRndInt(4, -100, 100);
PrintArray(newArray);
int sumOfDigitsOnOddPosition = SumOfDigitsOnOddPosition(newArray);
Console.WriteLine(sumOfDigitsOnOddPosition);