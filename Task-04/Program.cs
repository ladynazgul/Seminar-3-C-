// Определить количество цифр в числе
// Первый способ

// Console.WriteLine("Введите число: ");
// string a = Console.ReadLine() ?? "0";

// int b = a.Length;

// Console.WriteLine($"Число {a} имеет {b} цифр");

// Второй способ - то что сделали в группе на семинаре

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine() ?? "0");

int count = 0;
int current = A;

while (current >= 1)
{
    current = current / 10;
    count++;
}

Console.WriteLine(count);

// Третий способ - через символьный тип char - этот код показывает сумму цифр числа, а не их количество!

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