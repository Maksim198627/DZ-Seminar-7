// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] array = new double[3, 4]
{

    {1,2 ,3, 4},
    {5,6,7,8},
    {9,10,11,12}

    };

for (int y = 0; y < array.GetLength(0); y++)
{
    for (int x = 0; x < array.GetLength(1); x++)

        System.Console.Write(array[y, x] + " ");
    System.Console.WriteLine();
}


void SredneeArifmetich(double[,] array)
{
    double sum = 0;
    for (int y = 0; y < array.GetLength(0); y++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            sum = sum + array[y, x];
        }
        System.Console.WriteLine(Math.Round(sum / array.GetLength(1), 2));
        sum = 0;
    }
}
System.Console.WriteLine("Среднее арифметическое заданного массива в каждой строке: ");
SredneeArifmetich(array);
System.Console.Write("Для продолжения нажмите любую кнопку:  ");
Console.ReadKey();


