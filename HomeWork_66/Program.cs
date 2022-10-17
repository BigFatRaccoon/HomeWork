//  Задайте значения M и N.
//  Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int m = InputMessage("Введите число M: ");
int n = InputMessage("Введите число N: ");
if (m > n)
{
    Console.WriteLine("M не моджет быть больше N!!!");
}
else
{
    Console.WriteLine(TaskNaturSum(m, n));
}

int InputMessage(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int TaskNaturSum(int m, int n, int sum = 0)
{
    if (m > n)
    {
        return sum;
    }
    sum += m;
    m++;
    return TaskNaturSum(m, n, sum);
}
