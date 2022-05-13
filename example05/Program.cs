Console.WriteLine("Введите трехзначное число:");
int A = int.Parse(Console.ReadLine());
int result = 0;
if (100 <= A && A <= 999) 
{
    result = A % 10;
    Console.Write ("Последняя цифра числа = ");
    Console.WriteLine (result);
}    
else
{
    Console.Write ("Не является 3х значным числом!");
}