// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

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
void DetectPosition(int[,] arr)
{
    Console.WriteLine("Введите номер позиции строки! : ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер позиции столбца! : ");
    int n = Convert.ToInt32(Console.ReadLine());
    if ((m < arr.GetLength(0) && m >= 0) || (n < arr.GetLength(1) && m >= 0))
    {
        Console.WriteLine($"Элемент в строке {m} столбце {n} равен : {arr[m,n]}");
    }
    else Console.WriteLine("Такой позиции нет!");

}

int[,] massiv = SizeArray();
TypeArray(massiv);
FillingArray(massiv);
Console.WriteLine();
TypeArray(massiv);
Console.WriteLine();
DetectPosition(massiv);

