// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int TextUsera(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int arrayStroka = TextUsera("Введите количество строк в массиве: ");
int arrayStolbec = TextUsera("Введите количество столбцов в массиве: ");
int stroka = TextUsera("Расположение по индексу СТРОКИ: ");
int stolbec = TextUsera("Расположение по индексу СТОЛБЦА: ");
System.Console.WriteLine();

int[,] numbers = new int[arrayStroka, arrayStolbec];

void NewRandomArray(int[,] array)
{
    for (int y = 0; y < array.GetLength(0); y++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            array[y, x] = new Random().Next(1, 5);
            Console.Write(array[y, x] + "\t");
        }
        System.Console.WriteLine();
    }
}

NewRandomArray(numbers);

if (stroka < numbers.GetLength(0) && stolbec < numbers.GetLength(1))
{
    System.Console.WriteLine(numbers[stroka, stolbec]);
}
else System.Console.WriteLine($"{stroka}{stolbec} -> такого числа в массиве нет");


System.Console.Write("Для продолжения нажмите любую кнопку:  ");
Console.ReadKey();

