/*  //Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
 int size = 12;
 int minValue = 100;
 int maxValue = 999;
 int[] array = new int[size];

 for (int i = 0; i <array.Length; ++i)
 {
    array[i] = new Random().Next(minValue, maxValue + 1);
 }

Console.WriteLine(string.Join(",", array));

int result = 0;
for(int i = 0; i < array.Length; ++i)
{
    if (array[i] % 2 == 0)
    {
result += 1;
    }
}
Console.WriteLine("Количество четных чисел в массиве - " + result); */

/* //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int size = 10;
 int minValue = 1;
 int maxValue = 999;
 int[] array = new int[size];

 for (int i = 0; i <array.Length; ++i)
 {
    array[i] = new Random().Next(minValue, maxValue + 1);
 }

Console.WriteLine(string.Join(",", array));

int sum = 0;

for (int i = 1; i <array.Length; i++)
{
    if(i%2 == 1)
    {
    sum += array[i];
    }
}
Console.WriteLine(sum); */
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/* int size = 5;
double[] array = new double[size];
double min = 1;
double max = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i]< min)
    {
        min = array[i];
    }
}
Console.WriteLine(string.Join(",", array));
Console.WriteLine("Максимальный элемент - " + Math.Round(max,2));
Console.WriteLine("Минимальный элемент - " + Math.Round(min,2));
Console.WriteLine("Разница между максимальным и минимальным элементами - " + Math.Round((max-min),2));
 */
