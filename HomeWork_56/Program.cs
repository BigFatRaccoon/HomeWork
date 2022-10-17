// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Write("Введите количество строк массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива:");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, colums];
FillArray(array);
PrintArray(array);

MinSummElementRows(array);


int[,] FillArray(int[,] fillArr, int min = 1, int max = 10)
{
    Random random = new Random();
    for (int i = 0; i < fillArr.GetLength(0); i++)
    {
        for (int j = 0; j < fillArr.GetLength(1); j++)
        {
            fillArr[i, j] = random.Next(min, max);
        }
    }
    return fillArr;
}

void PrintArray(int[,] arrayPrint)
{
    for (int i = 0; i < arrayPrint.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arrayPrint.GetLength(1); j++)
        {
            Console.Write("  " + arrayPrint[i, j] + "  ");
        }
        Console.WriteLine("]");
    }
}

void MinSummElementRows(int[,] array)
{
    int summ = 0;
    int[] compare = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i, j];
        }
        Console.WriteLine($"сумма {i + 1} строки = {summ}");
        compare[i] = summ;
        summ = 0;
    }
    int minValue = compare[0];
    int indexMin = 1;
    for (int i = 1; i < compare.Length; i++)
    {
        if (minValue > compare[i]) { minValue = compare[i]; indexMin = i + 1; }
    }
    Console.WriteLine($"Строка массива под номером {indexMin}, имеет минимальную сумму элементов !");
}