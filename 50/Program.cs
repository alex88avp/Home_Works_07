// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();
Console.Write("Введите позицию A: ");
int posA = int.Parse(Console.ReadLine());
Console.Write("Введите позицию B: ");
int posB = int.Parse(Console.ReadLine());

int[,] array = GetArray(4, 4);
PrintArray(array);
Console.WriteLine();
ElementValue(array);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void ElementValue(int[,] arr)
{
    if (posA < arr.GetLength(0) && posB < arr.GetLength(1))
    {
        object element = arr.GetValue(posA, posB);// не знаю, насколько компетентно было использовать данный метод в моём случае
        Console.WriteLine(element);                // по другому никак не получалось решить((
    }
    else
    {
        Console.WriteLine("такого элемента нет");
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }

}