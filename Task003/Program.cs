// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Methods

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[,] FindMatrixProduct(int[,] firstMatr, int[,] secondMatr)
{
    int[,] product = new int[firstMatr.GetLength(0), secondMatr.GetLength(1)];
    for (int i = 0; i < firstMatr.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatr.GetLength(1); k++)
            {
                sum += firstMatr[i, k] * secondMatr[k, j];
            }
            product[i, j] = sum;
        }
    }
    return product;
}

// Code
Console.WriteLine("Введите количество строк первой матрицы");
int firstMatrixRows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы");
int firstMatrixColumns = int.Parse(Console.ReadLine());
int secondMatrixRows = firstMatrixColumns;
Console.WriteLine("Введите количество столбцов второй матрицы");
int secondMatrixColumns = int.Parse(Console.ReadLine());
int[,] firstMatrix = GetArray(firstMatrixRows, firstMatrixColumns);
Console.WriteLine("Первая матрица:");
PrintArray(firstMatrix);
int[,] secondMatrix = GetArray(secondMatrixRows, secondMatrixColumns);
Console.WriteLine("Вторая матрица:");
PrintArray(secondMatrix);
int[,] productArray = FindMatrixProduct(firstMatrix, secondMatrix);
Console.WriteLine("Произведение двух матриц:");
PrintArray(productArray);