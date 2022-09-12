//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// int[,] Matrix1(int[,] matrix)
// {
//     for (int i = 0; i < 1; i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             int x = matrix[i, j];
//             matrix[i, j] = matrix[matrix.GetLength(0) - 1, j];
//             matrix[matrix.GetLength(0) - 1, j] = x;
//         }
//         Console.WriteLine();
//     }
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     return (matrix);
// }

//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Console.WriteLine("Введите число m для определения кол-ва строк двумерного массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n для определения кол-ва столбцов двумерного массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] peremesh = new int[m,n];


// void FillArray(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(1,100);
//         }
//     }
// }

// void PrintArray(int[,] matrix)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// FillArray(peremesh);
// PrintArray(peremesh);
// // int[,] ChangeMatrix(int[,] matrix)
// // {   
// //     int[,] table = new int[matrix.GetLength(1),matrix.GetLength(0)];
// //     for(int i = 0; i < matrix.GetLength(0); i++)
// //     {
// //         for(int j = 0; j < matrix.GetLength(1); j++)
// //         {
// //             table[j,i] = matrix[i,j];
// //         }
// //     }
// //     return table;
// // }

// int temp = 0;
// for(int i = 0; i < m; i++)
// {
//     for(int j = 0; j < n; j++)
//     {
//         temp = peremesh[i,j];
//         peremesh[i,j] = peremesh[j,i];
//         peremesh[j,i] = temp;
//     }

// }
// Console.WriteLine("First: ");
// PrintArray(peremesh);
// int[,] table = new int[peremesh.GetLength(1),peremesh.GetLength(0)];
// for(int i = 0; i < m; i++)
// {
//     for(int j = 0; j < n; j++)
//     {
//         table[i,j] = peremesh[j,i];
//     }
// }

// Console.WriteLine("Second: ");
// PrintArray(peremesh);


// //Задача 59. 

// int[] FindMin(int[,] matrix)
// {
//     int min = matrix[0,0];
//     int[] MinElements = new int [matrix.GetLength(0)];
//     int min_i = 0;
//     int min_j  = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1),j++)
//         if ( matrix[i,j] < min)
//         {
//             min = matrix[i,j];
//             MinElements[0] = min;
//             min_i = i;
//             MinElements[1] = min_i;
//             min_j = j;
//             MinElements[2] = min_j
//         }
//     }
//     return MinElements;
// }
