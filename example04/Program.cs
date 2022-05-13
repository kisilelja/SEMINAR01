Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int min = -N;
while (min <= N)
{
    Console.Write(min);
    Console.Write(", ");
    min++ ;
}

