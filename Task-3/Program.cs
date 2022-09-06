// Написать программу вычисления произведения чисел от 1 до N

// Console.WriteLine("Задайте число A: ");
// int A = int.Parse(Console.ReadLine() ?? "0");

// int GetProd(int A)
// {
//     int n = 1;
//     int prod = 1; // Тут если начать с 0, то и все произведение становится 0:)))

//     for (int i = 0; i < A; i++)
//     {
//         prod = prod * n;
//     }
//     return prod;
// }

// int Prod = GetProd(A);

// Console.WriteLine($"Произведение чисел диапазона равно: {Prod}");

// Второй вариант

Console.WriteLine("Задайте число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

int length = N + 1;
int[] PArray = new int[N + 1];

for(int i = 1; i < length; i++)
{
	PArray[i] = i;
}

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 1; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetProd(int N, int[] array)
{
    int prod = 1;

    for (int i = 1; i < N + 1; i++)
    {
        prod = prod * array[i];
    }
    return prod;
}

PrintArray(PArray);
int Prod = GetProd(N, PArray);

Console.WriteLine($"Произведение чисел диапазона равно: {Prod}");
