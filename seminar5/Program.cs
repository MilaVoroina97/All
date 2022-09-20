// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.
//1 4 8 19
//5 -2 33 -2
//77 3 8 1

        // void PrintArray(int[,] table)
        //     {
        //     for (int i = 0; i < table.GetLength(0); i++)
        //         {
        //             for (int j = 0; j < table.GetLength(1); j++)
        //                 {
        //                     Console.Write(table[i,j] + "\t" );
        //                 }
        //             Console.WriteLine();
        //         }
        //     }

        // int[,] FillArray(int m, int n)
        //     {
        //         int[,] array = new int [m,n];
        //         for (int i=0;i<m;i++)
        //             {
        //                for (int j=0;j<n;j++) array[i,j] = new Random().Next(1,100);
        //             }
        //         return array;

        //     }
        // Console.WriteLine("Введите количество строк двумерного массива ");
        // int m = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Введите количество столбцов  двумерного массива ");
        // int n = Convert.ToInt32(Console.ReadLine());
        // int[,] mas = FillArray(m,n);
        // PrintArray(mas);

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5
// Console.WriteLine("Введите количество строк двумерного массива ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов  двумерного массива ");
// int n = Convert.ToInt32(Console.ReadLine());
//     int[,] FillArray(int m, int n)
//             {
//                 int[,] array = new int [m,n];
//                 for (int i=0;i<m;i++)
//                     {
//                        for (int j=0;j<n;j++) array[i,j] = i + j;
//                     }
//                 return array;

//             }
//         void PrintArray(int[,] table)
//             {
//             for (int i = 0; i < table.GetLength(0); i++)
//                 {
//                     for (int j = 0; j < table.GetLength(1); j++)
//                         {
//                             Console.Write(table[i,j] + "\t" );
//                         }
//                     Console.WriteLine();
//                 }
//             }
// int[,] mas = FillArray(m,n);
// PrintArray(mas);
// int max = mas[0,0];
// for (int i=0; i < mas.GetLength - 1; i++)
// {
//     for(int j = 0;j < mas.GetLength - 1; j++)
//     {
//         if(mas[i,j] > max)
//         {
//             max = max[i,j]
//         }
//     }  
// }

// //упорядочить по возрастанию, сверху вниз и слева направо по возврастанию, двумерный массив из случайных целых чисел

//         int[,] FillArray(int m, int n)
//             {
//                 int[,] array = new int [m,n];
//                 for (int i=0;i<m;i++)
//                     {
//                        for (int j=0;j<n;j++) array[i,j] = new Random().Next(1,100);
//                     }
//                 return array;

//             }
//         void PrintArray(int[,] table)
//             {
//             for (int i = 0; i < table.GetLength(0); i++)
//                 {
//                     for (int j = 0; j < table.GetLength(1); j++)
//                         {
//                             Console.Write(table[i,j] + "\t" );
//                         }
//                     Console.WriteLine();
//                 }
//             }

// void SortArray(int[] array)
// {
//     for(int i = 0; i < array.GetLength - 1; i++)
//     {
//         int max_position = i;
//         int max_position1 = j;
//         for(int j = i+1; j < array.GetLength; j++)
//         {
//             if(array[i,j] > array[max_position]) 
//             {
//                 max_position = j;
//             }
//         }
//         int temp = array[i];
//         array[i] = array[max_position];
//         array[max_position] = temp;
//     }
// }
//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
//Например, изначально массив
 //выглядел вот так:
//1 4 7 2
//5 9 2 3
//8 4 2 4
// Console.WriteLine("Введите количество строк двумерного массива ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов  двумерного массива ");
// int n = Convert.ToInt32(Console.ReadLine());
//     int[,] FillArray(int m, int n)
//             {
//                 int[,] array = new int [m,n];
//                 for (int i=0;i<m;i++)
//                     {
//                        for (int j=0;j<n;j++) array[i,j] = new Random().Next(1,10);
//                     }
//                 return array;

//             }
//         void PrintArray(int[,] table)
//             {
//             for (int i = 0; i < table.GetLength(0); i++)
//                 {
//                     for (int j = 0; j < table.GetLength(1); j++)
//                         {
//                             Console.Write(table[i,j] + "\t" );
//                         }
//                     Console.WriteLine();
//                 }
//             }
// int[,] mas = FillArray(m,n);
// PrintArray(mas);
// for(int i =0; i < m; i = i+2)
// {
//     for(int j = 0; j < n; j = j+2)
//     {
//         mas[i,j] = mas[i,j] * mas[i,j];
        
//     }
// }
// Console.WriteLine();
// PrintArray(mas);

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
//Например, изначально массив
 //выглядел вот так:
//1 4 7 2
//5 9 2 3
//8 4 2 4

// Console.WriteLine("Введите количество строк двумерного массива ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов  двумерного массива ");
// int n = Convert.ToInt32(Console.ReadLine());
//     int[,] FillArray(int m, int n)
//             {
//                 int[,] array = new int [m,n];
//                 for (int i=0;i<m;i++)
//                     {
//                        for (int j=0;j<n;j++) array[i,j] = new Random().Next(1,10);
//                     }
//                 return array;

//             }
//         void PrintArray(int[,] table)
//             {
//             for (int i = 0; i < table.GetLength(0); i++)
//                 {
//                     for (int j = 0; j < table.GetLength(1); j++)
//                         {
//                             Console.Write(table[i,j] + "\t" );
//                         }
//                     Console.WriteLine();
//                 }
//             }
// int[,] mas = FillArray(m,n);
// PrintArray(mas);
// for(int i = 1; i < m; i = i+2)
// {
//     for(int j = 1; j < n; j = j+2)
//     {
//         mas[i,j] = mas[i,j] * mas[i,j];
        
//     }
// }
// Console.WriteLine();
// PrintArray(mas);
        
// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

//  Console.WriteLine("Введите количество строк двумерного массива ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов  двумерного массива ");
// int n = Convert.ToInt32(Console.ReadLine());
//     int[,] FillArray(int m, int n)
//             {
//                 int[,] array = new int [m,n];
//                 for (int i=0;i<m;i++)
//                     {
//                        for (int j=0;j<n;j++) array[i,j] = new Random().Next(1,10);
//                     }
//                 return array;

//             }
//         void PrintArray(int[,] table)
//             {
//             for (int i = 0; i < table.GetLength(0); i++)
//                 {
//                     for (int j = 0; j < table.GetLength(1); j++)
//                         {
//                             Console.Write(table[i,j] + "\t" );
//                         }
//                     Console.WriteLine();
//                 }
//             }
// int[,] mas = FillArray(m,n);
// PrintArray(mas);
// int sum = 0;
// for(int i = 0; i < m; i=i+1)
// {
//     for(int j = 0; j < n; j = j+1)
//     {
//         if( i ==j)
//         {
//             sum = sum + mas[i,j];
        
//         }
        
//     }
// }
// Console.WriteLine();
// Console.WriteLine(sum);  





//упорядочить по возрастанию, сверху вниз и слева направо по возврастанию, двумерный массив из случайных целых чисел

Console.WriteLine("Hello, World");