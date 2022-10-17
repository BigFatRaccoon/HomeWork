// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.WriteLine("Массив заполненный спиралью: ");
int m = 4;
int[,] arr = new int[m, m];
FillSpirallAray(arr);


void FillSpirallAray(int[,] arr)
{
    int prod = arr.GetLength(0) * arr.GetLength(1);
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= prod)
    {
        arr[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < columns - 1)
        { j++; }
        else if (i < j && i + j >= rows - 1)
        { i++; }
        else if (i >= j && i + j > columns - 1)
        { j--; }
        else
        { i--; }
    }
    PrintArray(arr);
}

void PrintArray(int[,] num)
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            Console.Write(num[i, j] + "\t");
        }
        Console.WriteLine();
    }
}