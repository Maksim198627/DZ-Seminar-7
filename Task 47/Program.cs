// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void NewArray(double[,] array, int a, int b)
{
    for (int y = 0; y < a; y++)
    {
        for (int x = 0; x < b; x++)
        {
            array[y, x] = new Random().NextDouble() * 5;
            System.Console.Write(Math.Round(array[y, x], 1) + " ");
        }
        System.Console.WriteLine();
    }
}

System.Console.Write("Введите точку a: ");
int a = Convert.ToInt32(Console.ReadLine()!);

System.Console.Write("Введите точку b: ");
int b = Convert.ToInt32(Console.ReadLine()!);

double[,] array = new double[a, b];

NewArray(array, a, b);

System.Console.Write("Для продолжения нажмите любую кнопку:  ");
Console.ReadKey();