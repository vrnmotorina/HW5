//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите число M");  
 int m = Convert.ToInt32( Console.ReadLine() );
 int sum = 0;
for (int i = 0; i < m; i++)
    {
     Console.WriteLine("Введите число: "); 
     int a = Convert.ToInt32( Console.ReadLine() );
     if (a > 0)
        { 
        sum++;
        }
    }
Console.WriteLine("Количество положительных чисел = {0}", sum);
Console.ReadKey();

/* // Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b1 - b2)/(k2 - k1);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}"); */
