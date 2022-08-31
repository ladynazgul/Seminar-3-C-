// Возведите число А в натуральную степень В, используя цикл

Console.WriteLine("Задайте число: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Задайте показатель степени: ");
int B = int.Parse(Console.ReadLine() ?? "0");

int Exp(int x, int n)
{
	int res = x;
	for (int i = 1; i < n; i++)
	{
		res *= x;
	}
	return res;
}

int num = Exp(A, B);
Console.WriteLine($"Число {A} в степени {B} равно {num}");