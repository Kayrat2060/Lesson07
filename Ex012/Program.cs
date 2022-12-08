// Урок 7. Двумерные массивы
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами от -10,0 до 10,0.
// m = 3, n = 4.
// 0,5 7,0 -2,0 -0,2
// 1,0 -3,3 8,0 -9,9
// 8,0 7,8 -7,1 9,0

// double[,] FillArray(int m, int n)
// {
//     double[,] array = new double[m, n];
//     double temp = 0;
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             temp = new Random().Next(-10, 10) + new Random().NextDouble();
//             array[i, j] = Math.Round(temp, 1);
//         }
//     }
//     return array;
// }
// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Введите количество строк матрицы: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов матрицы: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine();
// double[,] array = FillArray(m, n);
// PrintArray(array);

// ---------------------------------

// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// void NumberInArray(int number, int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == number)
//             {                
//                 Console.WriteLine($"Число {number} присутствует в массиве, оно находится: строка {i+1}, столбец {j+1}");
//                 return;
//             }
//         }
//     }
//     Console.WriteLine($"Число {number} отсутствует в массиве");
// }
// Console.WriteLine();
// Console.Write("Введите количество строк матрицы: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов матрицы: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine();
// int[,] array = FillArray(m, n);
// PrintArray(array);
// Console.WriteLine();
// Console.Write("Введите число: ");
// int isNumberInArray = int.Parse(Console.ReadLine());
// Console.WriteLine();
// NumberInArray(isNumberInArray, array);
// Console.WriteLine();

// -------------------------------

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
double[] AverageColumn(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    double[] arrayAverageColumn = new double[n];
    double average = 0;
    for (int j = 0; j < n; j++)
    {
        for (int i = 0; i < m; i++)
        {
            average = average + array[i, j];
        }
        arrayAverageColumn[j] = average / m;
        average = 0;
    }
    return arrayAverageColumn;
}
void PrintAverageColumn(double[] array)
{
    Console.Write($"Среднее арифметическое каждого столбца: " + Math.Round(array[0], 2));
    for (int i = 1; i < array.Length; i++)
    {
            Console.Write(";  " + Math.Round(array[i], 2));
    }
        Console.WriteLine();
}
Console.WriteLine();
Console.Write("Введите количество строк матрицы: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = FillArray(m, n);
PrintArray(array);
Console.WriteLine();
double[] arrayAverageColumn = AverageColumn(array);
PrintAverageColumn(arrayAverageColumn);
Console.WriteLine();