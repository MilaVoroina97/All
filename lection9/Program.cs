// // вариация задачи 41 - пользователь не задает сколько чисел он введет (то есть число M),
// а подсчет количества чисел производится после того,
// как пользователь не ввел информацию и нажал Enter.

// Console.Write("Введите числа (через пробел) и нажмите Enter: ");
// int[] mass = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;
// for (int i = 0; i < mass.Length; i++)
// {
// if (mass[i] > 0)
// count++;
// Console.WriteLine(mass[i]);
// }
// Console.WriteLine($"Положительных чисел: {count}");

//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

//         int[,] FillArray(int m, int n)
//             {
//                 int[,] array = new int [m,n];
//                 for (int i=0;i<m;i++)
//                     {
//                        for (int j=0;j<n;j++) array[i,j] = new Random().Next(1,100);
//                     }
//                 return array;

//             }
//         Console.WriteLine("Введите количество строк двумерного массива ");
//         int m = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Введите количество столбцов  двумерного массива ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         int[,] mas = FillArray(m,n);
//         PrintArray(mas);

// for(int i = 0; i < n; i++)
// {
//     int temp = 0;    
//     temp = mas[0,i]; // по всем столбикам пробегаем через i
//     mas[0,i] = mas[m-1,i]; // индекс последней строчки
//     mas[m-1,i] = temp;   // из колонки надо вычесть единицу , потому что не считается 0 строка 
// } 

// Console.WriteLine();       
// PrintArray(mas);


// Второй вариант решения задачи
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


//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, 
//программа должна вывести сообщение для пользователя.
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

        // int[,] matrix = new int[n,m];
        // for(int i = 0; i < m; i++)
        // {
        //     for(int j = 0; j < n; j++)
        //     {
        //         matrix[i,j] = mas[j,i];
        //     }
        // }
        // Console.WriteLine();
        // PrintArray(matrix);


// Второе решение:
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
        // int temp = 0;

        // for(int i = 0; i < m; i++)
        // {
        //     for(int j = 0; j < n; j++)
        //     {
        //         temp = mas[i,j];
        //         mas[i,j] = mas[j,i];
        //         mas[j,i] = temp;
        //     }
        // }
        // int[,] matrix = new int[m,n];
        // for(int i = 0; i < m; i++)
        // {
        //     for(int j = 0; j < n; j++)
        //     {
        //         matrix[i,j] = mas[j,i];
        //     }
        // }
        // Console.WriteLine();
        // PrintArray(matrix);
       
// Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// void PrintArray(int[,] table)
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

//         int[,] FillArray(int m, int n)
//             {
//                 int[,] array = new int [m,n];
//                 for (int i=0;i<m;i++)
//                     {
//                        for (int j=0;j<n;j++) array[i,j] = new Random().Next(1,100);
//                     }
//                 return array;

//             }
//         Console.WriteLine("Введите количество строк двумерного массива ");
//         int m = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Введите количество столбцов  двумерного массива ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         int[,] mas = FillArray(m,n);
//         PrintArray(mas);

//         int[] FrequencyDictionary(int[,] matrix)
//         {
//             int[] count = new int[100];
//             for(int i = 0; i < m; i++)
//             {
//                 for(int j = 0; j < n; j++)
//                 {
//                     count[matrix[i,j]] += 1; // count[matrix[0,0] - 1] count[25] = count[25]+1 , count[matrix[0,1] - 1] = count[95] + 1; count[matrix[2,0]- 1] = count[25] = count[25] +1+1 
//                 }
//             }
//             return count;
//         }

// void CountArray(int[] count)
// {
//     for(int i = 0; i < count.Length; i++)
//     {
//         if(count[i] > 0) 
        
//         {
//             Console.WriteLine($"Число {i} встречается {count[i]} раз"); // count[25] = 2; 26 = 2
//         }
//     }
//     Console.WriteLine();
// }

// int[] result = FrequencyDictionary(mas);
// CountArray(result);

//Задача 59. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

void PrintArray(int[,] table)
            {
            for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                        {
                            Console.Write(table[i,j] + "\t" );
                        }
                    Console.WriteLine();
                }
            }

        int[,] FillArray(int m, int n)
            {
                int[,] array = new int [m,n];
                for (int i=0;i<m;i++)
                    {
                       for (int j=0;j<n;j++) array[i,j] = new Random().Next(1,100);
                    }
                return array;

            }
        Console.WriteLine("Введите количество строк двумерного массива ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов  двумерного массива ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] mas = FillArray(m,n);
        PrintArray(mas);

int[] FindMinNumberAndPosotion(int[,] matrix)
{
    int[] minElementsLine = new int[3];
    int min = matrix[0,0];
    int mini = 0;
    int minj = 0;

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            if(matrix[i,j] < min)
            {
                min = matrix[i,j];
                mini = i;
                minj = j;

            }
        }
    }
    minElementsLine[0] = min;
    minElementsLine[1] = mini;
    minElementsLine[2] = minj;
    return minElementsLine;
}
int[] count = FindMinNumberAndPosotion(mas);
Console.WriteLine(count[0]);

int[,] result = new int[m-1,n-1];
int x = 0;
int y = 0;
for(int i = 0; i < mas.GetLength(0); i++)
{
    for(int j = 0; j < mas.GetLength(1); j++)
    {
        if(count[1] != i && count[2] != j )
        {
            result[x,y] = mas[i,j]; //  result[0,0] = mas[1,0] , result [0,1]= mas[1,1]
            y++;                            // result[1,0] = mas [2,0], result[1,1] = mas[2,1]
        }          
    }

    y = 0;
    if(count[1] != i)
    {
        x++;
    }

}
Console.WriteLine();

PrintArray(result);



