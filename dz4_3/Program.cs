/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int []numbers = new int [8];
for (int i = 0; i < numbers.Length; i++)
{
    Random rnd = new Random();
    numbers[i] = rnd.Next(0, 100);
}
Console.WriteLine("[{0}]", string.Join(", ", numbers));