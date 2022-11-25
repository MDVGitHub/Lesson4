/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.WriteLine("Введите число А");
int A = Console.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Console.ToInt32(Console.ReadLine());

int Exponentiation ()
{
    for (int i = 0; i < B; i++)
    {
        int count = 0;
        int stek = count * A;
        return count;
    }
}
Console.WriteLine($"Результат возведения {A} в степень {B} равен {count}");