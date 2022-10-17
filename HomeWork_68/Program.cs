// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = InputMessage("Введите число M: ");
int n = InputMessage("Введите число N: ");
if (m < 0 && n < 0)
{
    Console.WriteLine("M и N должны быть положительные!!!");
}
else
{
    Console.WriteLine(TaskAkkerman(m, n));
}

int InputMessage(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int TaskAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return TaskAkkerman(m - 1, 1);
    }
    return TaskAkkerman(m - 1, TaskAkkerman(m, n - 1));
}
