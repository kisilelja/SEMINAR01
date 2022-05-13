Console.WriteLine("Введите число № 1: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число № 2: ");
int numberB = int.Parse(Console.ReadLine());
int max = numberA;
int min = numberB;
if (numberB > numberA)
{
    max = numberB;
    min = numberA;
}
Console.Write("Максимальное число: ");
Console.WriteLine(max);
Console.Write("Минимальное число: ");
Console.WriteLine(min);