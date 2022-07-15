// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("Введите число и мы тебе скажем четное оно или нет");
int a;
Console.WriteLine("Введите число a");
a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine($"Число a = {a} кратно двум");
}
else
{
    Console.WriteLine($"Число a = {a} не кратно двум");
}


