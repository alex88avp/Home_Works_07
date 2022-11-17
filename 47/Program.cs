// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
Random rnd = new Random();

double[,] array = FillArray(rows, columns, -100, 100);
PrintArray(array);

double[,] FillArray(int m, int n, int maxValue, int minValue)
{
    double[,] arr = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = Convert.ToDouble(rnd.Next(maxValue, minValue)/10.0);
        }
    }
    return arr;
}

void PrintArray(double[,] arr2)
{
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            Console.Write($"{arr2[i, j]} ");
        }
        Console.WriteLine();
    }
}
