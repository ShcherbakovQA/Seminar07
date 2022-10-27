// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

double[,] SizeArray()
{
    Console.WriteLine("Введите количество строк!: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов!: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[m, n];
    return array;
}

void TypeArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillingArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * 10, 1);
        }
    }
}

double[,] massiv = SizeArray();
Console.WriteLine();
TypeArray(massiv);
FillingArray(massiv);
Console.WriteLine();
TypeArray(massiv);
