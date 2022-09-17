// собрать строку с числами от a до b , a <= b

// string NumbersFor(int a, int b)
// {   
//     string result = String.Empty;
//     for( int i = a; i <= b; i++)
//     {
//         result+= $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return $"{a}" + NumbersRec(a+1, b); //додумать как сделать,чтобы было на один вызов рекурсии меньше
//     else return String.Empty;
// }
// Console.WriteLine(NumbersFor(1,10));
// Console.WriteLine(NumbersRec(2,5));


// наоборот вывести строку с убыванием чисел

// string NumbersFor(int a, int b)
// {   
//     string result = String.Empty;
//     for( int i = a; i >= b; i--)
//     {
//         result+= $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return NumbersRec(a + 1, b) + $"{a} "; 
//     else return String.Empty;
// }
// //Console.WriteLine(NumbersFor(1,10));
// Console.WriteLine(NumbersRec(1,10));

// требуется найти сумму чисел от 1 до n


// int SumNumbers(int n)
// {
//     int sum = 0;
//     for(int i = 1; i <= n; i++) sum += i;
//     return sum;
// }

// int SumRes(int n)
// {
//     if(n == 0) return 0;
//     else return n + SumRes(n-1);
// }
// Console.WriteLine(SumRes(0));

// Факториал числа

// int Factorial(int n)
// {
//     int factorial = 1;
//     for(int i = 1; i <= n; i++) factorial = factorial * i ;
//     
//     return factorial;
// }
// Console.WriteLine(Factorial(4));

// int FactorialRes(int n)
// {
//     if (n == 1) return 1;
//     else return n * FactorialRes(n-1);
// }
// Console.WriteLine(FactorialRes(4));


// Возвести числа а в степень n.

// int Stepen(int a, int n)
// {
//     int result = 1;
//     for(int i = 1; i <= n; i++) result *= a;
//     return result;
// }
// Console.WriteLine(Stepen(2,3));

// int Stepen(int a, int n)
// {
//     // if (n == 0) return 1;
//     // else return a * Stepen(a, n-1);
//     return n == 0 ? 1 : Stepen(a, n-1) *a; - альтернативный способ
// }
// Console.WriteLine(Stepen(2,3));

// int StepenRes(int a, int n)
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0 ) return StepenRes( a*a, n/2); - Улучшение программы
//     else return StepenRes(a, n-1) * a;
// }
// Console.WriteLine(StepenRes(3,2));



// Перебор слов
// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из T букв, которые можно построить из букв
// этого алфавита

// char[] s = {'а' , 'и', 'с', 'в'};
// int count = s.Length;
// int n = 1;
// char[] 
// for(int i = 0; i < count; i++)
// {
//     for(int j = 0; j < count; j++)
//     {
//         for(int k = 0; k < count; k++)
//         {
//             Console.WriteLine($"{n++, - 5}{s[i]}{s[j]}{s[k]}");
//         }
        
//     }
    
// }

//Общий случай решения задачи выше
// int n = 1;
// void FormWords(string alphabet, char[] word, int length = 0) // принимает на вход строку, где будут записываться сами буквы,из которых
// // потом будут составляться слова, далее принимает на вход массив из символов, куда будет записываться результат.
// {
    
//     if (length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for(int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FormWords(alphabet,word,length+1); 
//     }
// }

// FormWords("аисв", new char[2]);


// Посмотреть содержимое папки

// string path = @"C:\\All\\All_1\\lection4";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles(); // создаем массив типа файл инфо, класс который содержит инфу о каком-либо файле
// for(int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name); // вычленяем название всех файлов содержащихся в этой папке
// }

// Далее напишем рекурсию, которая будет бежат по всем файлам в папке

// void CatalogInfo(string path, string indent = "") // первый аргумент - путь, которые ведет к папке, второй - пустая строка, которая будет делать отступы для просмотра структуры папки
// {
//     DirectoryInfo catalog = new DirectoryInfo(path); // получаем информацию о директории, который находится по этому пути
    
//     DirectoryInfo[] catalogs = catalog.GetDirectories(); // получаем массив всех файлов, находящихся в этой папке
//     for(int i = 0; i < catalogs.Length; i++) // пробегаем по ним 
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}"); // выводим информацию о текущем каталоге
//         CatalogInfo(catalogs[i].FullName, indent + " "); // рекурсивно будем смотреть все папки и выведем все папки
//     }

//     FileInfo[] files = catalog.GetFiles(); // после того как выйдем из рекурсии, мы получим массив всех файлов в текущем директории
//     for(int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent}{files[i].Name}");

//     }
// }

// string path =  @"C:\\All\\All_1\\lection4";
// CatalogInfo(path);

// Игра в пирамики

// void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
// {
//     if(count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if(count > 1) Towers(some, on, with, count - 1);

// }
// Towers();

// Бинарное дерево 
// string emp = String.Empty;

// string[] tree = {emp,"/","*", "10","-","+",emp,emp,"4","2","1","3"};

// void InOrderTraversal(int pos = 1) // на вход принимаем ту позицию массива, с которой будем начинать 
// {
//     if(pos < tree.Length)// проверка - если наша позиция вылетела за кол-во элементов, хранящихся в дереве, то рекурсия закончится(когда позиция превзошла количество узлов в дереве)
//     {
//         int left = 2 * pos; // обозначаем левую часть дерева 2i
//         int right = 2 * pos + 1;// обозначаем правую часть дерева 2i + 1
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);// проверка - если мы не вылетаем за границы дерева и элемент, который там хранится, не является пустым(например позиции 6 и 7 в данном дереве пропущены), то рекурсивно мы запускаем обход дерева с текущей позиции.
//         Console.WriteLine(tree[pos]);//выводим узел с конкретным значением операции или числа 
//         if(right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);// проверка - если существует правая часть дерева и элемент, в который мы заходим не пустой, то мы рекурсивно обходим дерево в текущей позиции
//     }
// }
// InOrderTraversal();

// Числа Фибоначчи

decimal fRec = 0;

decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1: FibonacciRecursion(n-1) + FibonacciRecursion(n-2);
}


decimal FibonacciIteration(int n)
{
    fIte ++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for(int i = 2; i <=n; i++)
    {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        fIte++;
    }

    return result;

}

Console.ReadLine();
for(int n = 10; n <= 40; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte = 0;
}

Console.WriteLine();
Console.ReadLine();

for(int n = 10; n <= 40; n++)
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
    fRec = 0;
}
Console.ReadLine();