int[] CreateArray(int N)
{
    int[] array = new int[N*2+1]; // 31
    for(int i = -N; i <= N; i++) // -15 
    {
        array[i+N] = i;
        Console.WriteLine(array[i]);
        
    }
    return array;
}

int N = 15;
int[] massiv = CreateArray(N);
