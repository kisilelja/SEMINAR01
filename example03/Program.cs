Console.WriteLine("Введите число № 1: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число № 2: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число № 2: ");
int C = int.Parse(Console.ReadLine());
int max = A;
if (B > A) max = B;
if (C > A) max = C;
Console.Write("Максимальное число: ");
Console.WriteLine(max);

