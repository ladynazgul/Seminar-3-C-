// Подсчитать сумму цифр в числе

Console.Write("Введите число: ");
string S = Console.ReadLine() ?? "0";

int Length = S.Length;
int sum = 0;

for(int i = 0; i < Length; i++)
{
    char B = S[i];
    int A = (int)(B - '0');
    sum = sum + A;
}

Console.WriteLine(sum);