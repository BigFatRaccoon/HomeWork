// Задача 27:
//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int summ = 0;
int result = 0;
int num1;


while (number > 10)
{
    num1 = number % 10;
    summ = summ + num1;
    number = number / 10;
}
if (number<10)
{
    result = summ + number;
}

Console.WriteLine($"Сумма цифр  {result}");