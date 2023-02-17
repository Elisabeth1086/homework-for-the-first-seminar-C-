// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.Write("Введите первое число: ");
int number=Convert.ToInt32(Console.ReadLine());
if(number % 2==0)
{
    System.Console.Write($"Число {number} четное");
}
else
{
    System.Console.Write($"Число {number} нечетное");
}