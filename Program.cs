// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double[,] CreateRandom2dDoubleArray(int rows, int cols, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, cols];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {   
            Random rand = new Random();
            double number = rand.Next(minValue, maxValue + 1) + rand.NextDouble();
            newArray[i,j] = Math.Round(number, 1);
        }
    }
    return newArray;
}

void Show2dDoubleArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
/*
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandom2dDoubleArray(m, n, min, max);
Show2dDoubleArray(array);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
int[,] CreateRandom2dArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, cols];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
/*
Console.Write("Введите индекс строки: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ииндекс столбца: ");
int j = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(4, 4, 0, 10);
Show2DArray(myArray);

 if(i > myArray.GetLength(0) || j > myArray.GetLength(1))
    {
        Console.WriteLine($"Элемента с индексами [{i},{j}] в массиве нет. ");
    }
    else
    {   
        Console.WriteLine($"Значение элемента с индексами [{i},{j}] = {myArray[i,j]}. ");
    }
*/
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void AverageEachColums(int[,] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
            {
                double sum = 0;
                double average;
                int countCols = array.GetLength(1);

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[j, i];
                }
                
                average = sum / countCols;
                Console.Write($"{average}; ");
            }
}

int[,] myArray = CreateRandom2dArray(4, 4, 0, 10);
Show2DArray(myArray);
AverageEachColums(myArray);
