// Рекурсия

// сумма всех чисел от 1 до n

// int SummaLoop(int N)
// {
//     int sum = 0;
//     while(N > 0)
//     {
//         sum+= N;
//         N--;
//     }
//     return sum;
// }


// int SummaRec(int n)
// {
//     if(n ==0) return 0;
//     return n+SummaRec(n-1);
// }
// Console.WriteLine(SummaLoop(10));
// Console.WriteLine(SummaRec(200));

//Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

// string Output(int N)
// {
//     if(N==0) return "";
//     return Output(N-1) + " " + Convert.ToString(N); 4-5 1 3-5 2 2-5 3 1-5 4 0-5 5
// }
// Console.WriteLine(Output(5));

//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 6, 7, 8"

// string Output(int M, int N)
// {
//     if(M > N) return "";
//     return Output(M,N-1) + " " + Convert.ToString(N); // 4 3-8 5 4 2-8 6 4 1-8 7 4 0-8 8 
// }
//  Console.WriteLine(Output(4,8));

//  string Promezhytok(int M, int N)
//  {
//     string sum = "";
//     while(M <= N)
//     {
//         sum = Convert.ToString(N) + sum;
//         N--;
//     }
//     return sum;
//  }
//  Console.WriteLine(Promezhytok(4,8));

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

//  int Stepen(int A, int B)
//  {
//     int result = 1;
//     while(B > 0)
//     {
//         result = result * A;
//         B--;
//     }
//     return result;
//  }
//  Console.WriteLine(Stepen(3,5));

//   int Stepen1(int A, int B)
//   {
//     if (B == 0) return 1;
//     return Stepen1(A,B-1) * A;
//   }

//    Console.WriteLine(Stepen1(2,3));

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9

// int SummaOfNumber(int n)
// {
//     int sum = 0;
//     while(n > 0)
//     {
//         sum = sum + n % 10;
//         n = n / 10;
//     }
//     return sum;
// }
// Console.WriteLine(SummaOfNumber(5454));

// int SummaOfNumber1(int n)
// {
//     if (n == 0) return 0;
//     return n % 10 + SummaOfNumber(n / 10);
// }
// Console.WriteLine(SummaOfNumber1(5454));





