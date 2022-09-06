// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Задайте число A: ");
int A = int.Parse(Console.ReadLine() ?? "0");

int GetProd(int A)
{
    int n = 1;
    int prod = 1;

    for (int i = 0; i < A; i++)
    {
        prod = prod * n;
        n++;
    }
    return prod;
}

int Prod = GetProd(A);

Console.WriteLine($"Произведение чисел диапазона равно: {Prod}");
