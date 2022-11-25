/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.WriteLine("Программа возводит число А в степеь В");
Console.WriteLine();
Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());

int Exponentiation (int A, int B)
{
    int count = 1; 
    for (int i = 1; i <= B; i++)
    {
        count = count * A;
    }
    return count;
}
int exponentiation = Exponentiation ( A,  B);
Console.WriteLine($"Результат {exponentiation}");