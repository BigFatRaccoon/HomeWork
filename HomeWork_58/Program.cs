// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] matrix3 = new int[,]
{
    {2,4},
    {3,2}   };

int[,] matrix4 = new int[,]
{
    {3,4},
    {3,3},  };

Console.WriteLine("Первая матрица: ");
PrintMatrix(matrix3);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(matrix4);
Console.WriteLine("Произведение двух матриц: ");
multiplyMatrix(matrix3, matrix4);


void multiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)  // 2 цикла (это будут строки итоговой матрицы)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)  //2 цикла (это будут столбцы итоговой матрицы)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)  //3 цикла (для * элементов матрицы / и их сложения)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    PrintArray(resultMatrix);
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}