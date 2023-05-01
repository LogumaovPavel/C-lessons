// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int secondDigit (int num)
{
    while (num >= 100) num /= 10;
    int second = num%10;
    return second;
}
Console.WriteLine("Input  number:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num} -> {secondDigit(num)}");


// //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int input(string num)
{
System.Console.WriteLine($"{num}");
return Convert.ToInt32(Console.ReadLine());
}
int number = input("input number");
int fnumber(int number)
{
while (number > 999)
{
number /= 10;
}
return number % 10;
}
bool check(int number)
{
if (number < 100)
return false;
else return true;
}
if (check(number) != true)
Console.WriteLine($"{number} -> Третьей цифры нет");
else
Console.WriteLine($"{number} -> {fnumber(number)}");


//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string ss = "пока ничего";
string check(int number)
{
    if(number >= 6 && number < 8) ss = "это выходной";
    if(number >= 1 && number < 6) ss = "это не выходной";
    return ss;
}
 Console.WriteLine("Input  number:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{check(number)}");