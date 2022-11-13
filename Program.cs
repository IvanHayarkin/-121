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
/*
Console.WriteLine("Введите число: ");

int a = int.Parse(Console.ReadLine()!);

for (int i = 2; i <= a; i += 2)
Console.WriteLine($"Ответ: {i}");
*/

Console.WriteLine("Введите число: ");

if (Convert.ToInt32(Console.ReadLine()) % 2==0)
    Console.WriteLine("Tru");
else Console.WriteLine("false");
