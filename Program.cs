/*
Console.WriteLine("Введите число: ");

int a = int.Parse(Console.ReadLine()!);

int x = int.Parse(Console.ReadLine()!);

if (a > x)
{
   
    Console.WriteLine($"Это число самое большое:{a}");
}
if (x > a)
{
   
    Console.WriteLine($"Это число самое большое:{x}");
}
*/

Console.WriteLine("Введите число: ");

int a = int.Parse(Console.ReadLine()!);

for (int i = 2; i <= a; i += 2)
Console.WriteLine($"Ответ: {i}");