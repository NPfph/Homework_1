// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.WriteLine("Введи 3 числа и мы тебе скажем какое из них большее");
int a, b, c;
Console.WriteLine("Введите первое число a");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число b");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число c");
c = Convert.ToInt32(Console.ReadLine());

bool com1 = a > b && a > c;
bool com2 = b > a && b > c;
bool com3 = c > a && c > a;

if (com1) 
{
    Console.WriteLine($"Число a = {a} - большее");
}
else if (com2)
{
    Console.WriteLine($"Число b = {b} - большее");
}
else 
{
    Console.WriteLine($"Число c = {c} - большее");
}