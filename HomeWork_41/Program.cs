// Задача 41: 
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите размер массива чисел M: ");
double[] array = FillArray();
PrintArray(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++;
}
Console.WriteLine("Чисел больше 0: " + count);
Console.ReadKey();

double[] FillArray() 
{
    Random rnd = new Random();
    int Insert = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[Insert];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число №{i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

void PrintArray(double[] argument1) 
{
    Console.WriteLine("[" + String.Join("; ", argument1) + "]");
}