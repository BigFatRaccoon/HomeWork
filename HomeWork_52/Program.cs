// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] arrayMatrix = CreateMatrix(3, 4, 0, 10);
PrintMatrix(arrayMatrix);
FindEachColomnAvarageSum(arrayMatrix);
double[] arrayOfAvarageSums = FindEachColomnAvarageSum(arrayMatrix);
PrintArray(arrayOfAvarageSums);

double[] FindEachColomnAvarageSum(int[,] array)
{
    int k = 0;
    double[] result = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = default;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        result[k] = Math.Round(sum/array.GetLength(0), 1);
        k++;
    }
    return result;
}

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j],3} ");
        }
    Console.WriteLine();
    }
}

void PrintArray(double[] array)
{
    Console.WriteLine();
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($" среднее арифметическое {array[i]}; ");
        }
    }
    Console.WriteLine();
 }