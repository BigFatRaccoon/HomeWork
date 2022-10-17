// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.Write("Введите количество строк массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива:");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, colums];

FillArray(array);
PrintArray(array);
Console.WriteLine("элементы каждой строки упорядочены по убыванию ");
SortArray(array);
PrintArray(array);

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

int[,] SortArray(int[,] sortArray)
{
    int temp;
    for (int i = 0; i < sortArray.GetLength(0); i++)
    {
        for (int j = 0; j < sortArray.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < sortArray.GetLength(1); k++)
            {
                if (sortArray[i, j] < sortArray[i, k])
                {
                    temp = sortArray[i, j];
                    sortArray[i, j] = sortArray[i, k];
                    sortArray[i, k] = temp;
                }
            }
        }
    }
    return sortArray;
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