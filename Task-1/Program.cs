// Найти кубы чисел от 1 до N

Console.WriteLine("Задайте число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

int[] GetCubes(int N)
{
    int[] CubesArray = new int[N + 1];
    for (int i = 1; i < CubesArray.Length; i++)
    {
        CubesArray[i] = i * i * i;
    }
    return CubesArray;
}

void PrintTable(int[] Array)
{
    for (int i = 1; i < Array.Length; i++)
    {
        System.Console.Write($"{i} ^ 3 = ");
        System.Console.WriteLine(Array[i]);
    }
}

int[] CubesTable = GetCubes(N);
PrintTable(CubesTable);