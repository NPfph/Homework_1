// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введи 2 числа и мы тебе скажем какое из них больше");
int a, b;
Console.WriteLine("Введите первое число a");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число b");
b = Convert.ToInt32(Console.ReadLine());

bool com1 = a > b;
bool com2 = a == b;
bool com3 = a < b;

if (com1)
{
    Console.WriteLine($"Число a = {a}, b = {b} --> max = {a}, min = {b}");
}
else if (com2)
{
    Console.WriteLine($"Числа a = {a} и b = {b} равны");
}
else 
{
    Console.WriteLine($"Число a = {a}, b = {b} --> max = {b}, min = {a}");
}