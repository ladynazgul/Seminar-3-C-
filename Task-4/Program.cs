// Показать кубы чисел, заканчивающихся на четную цифру

// int[] array = new int[] { 11, 51, 18, 25, 14, 23, 22, 15, 12 };
// int n = array.Length;

// for (int i = 0; i < n; i++)
// {
//     int x = array[i];
//     int cube = x * x * x;
//     if (cube % 2 == 0) System.Console.Write(cube + " ");
// }
// System.Console.WriteLine();

// Второй способ - через метод

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(2, 50);
        index++;
    }
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

int[] arr = new int[20];

FillArray(arr);
PrintArray(arr);
Console.WriteLine();

int[] Evens = arr.Where(el => el % 2 == 0).ToArray();

PrintArray(Evens);

int[] EvenCubes = Evens.Where(el => el * el * el);

PrintArray(EvenCubes); 
