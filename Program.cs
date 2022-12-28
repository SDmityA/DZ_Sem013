// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// ************Задача 1*******************
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк масива:");
// int row=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов масива:");
// int col=Convert.ToInt32(Console.ReadLine());

// double [,] matrix= new double [row,col];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix [i,j]= Math.Round(new Random().NextDouble()*(10+10)-10 , 1);
//         Console.Write(matrix[i,j]+":");
//     }
//     Console.WriteLine();
// }

// **************************Конец*************************
// *********************Задача 2*************************
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите номер ряда");
// int row=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца");
// int col=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int [,] matrix= new int [new Random().Next(1,10),new Random().Next(1,10)];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix [i,j]= new Random().Next(1,100);
//         Console.Write(matrix[i,j]+":");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// if (row>matrix.GetLength(0)||col>matrix.GetLength(1))
// {
//     Console.WriteLine("Такого элемента в массиве нет");
// }
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (i==row-1&&j==col-1)
//         {
//         Console.WriteLine(matrix[i,j]);
//         break;
//         }
//     }
    
// }    

// ************************Конец*************************
// *********************Задача 3*************************
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int [,] matrix= new int [new Random().Next(1,5),new Random().Next(1,5)];
// double count=0;

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix [i,j]= new Random().Next(1,100);
//         Console.Write(matrix[i,j]+":");
//     }
//     Console.WriteLine();
// }
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         count= count+matrix[i,j]; 
//     }
//     count=count/matrix.GetLength(0);
//     Console.Write(count+" ;");
// }

// ****************Конец*********************
