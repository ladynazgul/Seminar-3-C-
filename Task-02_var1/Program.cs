// Найти сумму чисел от 1 до А

Console.WriteLine("Задайте число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

int length = N + 1;
int[] SumArray = new int[N + 1];

for(int i = 1; i < length; i++)
{
	SumArray[i] = i;
}

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetSum(int N, int[] array)
{
    int sum = 0;

    for (int i = 0; i < N + 1; i++)
    {
        sum = sum + array[i];
    }
    return sum;
}

PrintArray(SumArray);
int Sum = GetSum(N, SumArray);

Console.WriteLine($"Сумма чисел диапазона равна: {Sum}");

// Надо еще придумать как сделать так, чтобы само число N тоже входило в диапазон - сделано!