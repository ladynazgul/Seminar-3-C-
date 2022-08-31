// Найти сумму чисел от 1 до А

Console.WriteLine("Задайте число A: ");
int A = int.Parse(Console.ReadLine() ?? "0");

int GetSum(int A)
{
    int n = 1;
    int sum = 0;

    for (int i = 0; i < A; i++)
    {
        sum = sum + n;
        n++;
    }
    return sum;
}

int Sum = GetSum(A);

Console.WriteLine($"Сумма чисел диапазона равна: {Sum}");