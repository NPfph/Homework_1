// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите число n и мы тебе покажем все четные числа от 1 до n");
int n;
Console.WriteLine("Введите число n");
n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < n; i++)
if (i % 2 == 0)
{
    Console.WriteLine(i);
}