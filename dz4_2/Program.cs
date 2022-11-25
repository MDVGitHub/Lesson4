/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

int NumbersStringSumm (int N)
{
    int Length = Convert.ToString(N).Length;
    int summ = 0;
for (int i = Length; i >= 0; i--)
{
    summ = Length;
}
    return summ;
}
int allNumbersSumm = NumbersStringSumm( N );
Console.WriteLine(allNumbersSumm);
