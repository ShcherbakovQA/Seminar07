// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] SizeArray()
{
    Console.WriteLine("Введите количество строк! : ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов! : ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];
    return array;
}
void TypeArray(int[,] arr)
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
void FillingArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
}

void Mean(int[,] arr)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum = sum + arr[j, i];
            if (j == (arr.GetLength(0) - 1))
            {
                Console.WriteLine($"Среднее арифметическое стобца {i} = {Math.Round(sum / (j + 1), 1)}");
                sum = 0;
            }
        }
    }
}

int[,] massiv = SizeArray();
TypeArray(massiv);
FillingArray(massiv);
Console.WriteLine();
TypeArray(massiv);
Console.WriteLine();
Mean(massiv);
