// Подсчитать сумму цифр в числе

// Console.Write("Введите число: ");
// string S = Console.ReadLine() ?? "0";

// int Length = S.Length;
// int sum = 0;

// for(int i = 0; i < Length; i++)
// {
//     char B = S[i];
//     int A = (int)(B - '0');
//     sum = sum + A;
// }

// Console.WriteLine(sum);

// Второй способ

// Console.WriteLine("Введите число: ");
// int X = int.Parse(Console.ReadLine() ?? "0");
// int sum = 0;

// while (X > 0)
// {
//     sum = sum + (X % 10);
//     X = X / 10;
// }

// Console.WriteLine(sum);

// Третий способ

int N = new Random().Next(1, 100000);
int sumDigit = 0;
System.Console.Write($"Сумма цифр числа {N} равна ");

while (N > 0)
{
    int digit = N % 10;
    sumDigit = sumDigit + digit;
    N = N / 10;
}

System.Console.WriteLine(sumDigit);
System.Console.WriteLine();