// ___________________________Задача 47__________________
// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int colomns = Convert.ToInt32(Console.ReadLine());

// double [,] matrix= new double[rows,colomns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j]= Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 2);
//     }
// }

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine();
// }


// ____________________________Задача 50________________________________
// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого
//  элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int colomns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, colomns];

// void FillingArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j]= new Random().Next(1,10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            Console.Write(matrix[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Введите индекс строки: ");
// int searchNum1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите индекс столбца: ");
// int searchNum2 = Convert.ToInt32(Console.ReadLine());

// void SearchElementsArray(int searchNum1, int searchNum2)
// {
//     if (searchNum1 < matrix.GetLength(0) && searchNum2 < matrix.GetLength(1))
//     {
//         Console.WriteLine($"Число: [ {matrix[searchNum1, searchNum2]} ]");
//     }
//     else
//     {
//         Console.WriteLine($" {searchNum1}, {searchNum2} Такго элемента нет");
//     }
// }

// FillingArray();
// SearchElementsArray(searchNum1, searchNum2);
// PrintArray();

// ________________________Задача 52____________________________________ 
// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int colomns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, colomns];

void FillingArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]= new Random().Next(1,10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         for (int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
}

void AverageColomns()
{
    Console.Write("Среднее арифметическое по столбцу:");
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        double average = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            average += matrix[i,j];
        }
        Console.Write($"[{average=average/matrix.GetLength(1)}] ");
    }
    
}

FillingArray();
PrintArray();
AverageColomns();
