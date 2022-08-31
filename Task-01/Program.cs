// Показать таблицу квадратов чисел от 1 до N

// Способ решения без методов и массивов в джоплине, здесь показано с методами

Console.WriteLine("Задайте число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

int[] GetSqrt(int N)
{
    int[] SqrtArray = new int[N + 1];
    for (int i = 1; i < SqrtArray.Length; i++)
    {
        SqrtArray[i] = i * i;
    }
    return SqrtArray;
}

void PrintTable(int[] Array)
{
    for (int i = 1; i < Array.Length; i++)
    {
        System.Console.Write($"{i} ^ 2 = ");
        System.Console.WriteLine(Array[i]);
    }
}

int[] SqrtTable = GetSqrt(N);
PrintTable(SqrtTable);