//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] GetArray(int m, int n) 
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            result[i, j] = new Random().NextDouble();
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j)
        {
           Console.Write(Math.Round(array[i, j], 1)+"; ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine());

double[,] result = GetArray(rows, columns);
PrintArray(result);


// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*   int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j)
        {
           Console.Write(array[i, j]+" ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine());

int[,] result = GetArray(rows, columns, 0, 9);
PrintArray(result);

Console.WriteLine("Введите номер строки - ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите номер столбца -");
int n = int.Parse(Console.ReadLine());

if(m < result.GetLength(0) && n < result.GetLength(1))
{
Console.WriteLine(result[m, n]);
}
else
{
Console.WriteLine("Такой элемент отсутствует");  
} */

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/* int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j)
        {
           Console.Write(array[i, j]+" ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine());

int[,] result = GetArray(rows, columns, 0, 9);
PrintArray(result);


for(int j= 0; j < result.GetLength(1); j++)
{
    int a=0;
    for(int i= 0; i < result.GetLength(0); i++)
    {
     a += result[i, j];
    }
     Console.WriteLine($"Cреднее арифметическое элементов столбца {j + 1} = {(float)a/rows}");   
}
  */
