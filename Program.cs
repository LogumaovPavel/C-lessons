//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Input first number:");
Console.WriteLine("Input number:");
Console.WriteLine("Input first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number:");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2)
{
    Console.Write($"a={num1}, b={num2} -> {num1} = max");
}
else
{
    Console.Write($"a={num1} , b={num2} -> {num2} = max");
}


// // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Input first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number:");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.Write($"{num1} - Максимальное число");   
    }
}
else
{
    if (num2 > num3)
    {
        Console.Write($"{num2} - Максимальное число");
    }
    else
    {
        Console.Write($"{num3} - Максимальное число");
    }
}


// // Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Input number:");
int num = Convert.ToInt32(Console.ReadLine());
if(num%2 == 0)
{
    Console.Write($"{num} - четное число");
}
else
{
    Console.Write($"{num} - нечетное число");
}


// //Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Input number:");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= num)
{
    if (count%2 == 0)
    {
        Console.WriteLine ($"{count}");
    }
    count++;
}