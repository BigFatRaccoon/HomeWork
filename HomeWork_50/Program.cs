// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Write("Введите номер строки : ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца : ");
int j = Convert.ToInt32(Console.ReadLine());

int[,] arrayMatrix = CreateMatrix(3, 4, 0, 99);
PrintMatrix(arrayMatrix);

int value = default;
if (i > arrayMatrix.GetLength(0) || j > arrayMatrix.GetLength(1))
{
    Console.WriteLine(" такого элемента в массиве нет");
}
else Console.WriteLine(value = arrayMatrix[i - 1, j - 1]);

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
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}