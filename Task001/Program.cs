// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int [,] SortArray(int[,] sortedArray)
{
    for (int i = 0; i < sortedArray.GetLength(0); i++)
    {
        for (int j = 0; j < sortedArray.GetLength(1) - 1; j++)
        {
            int maxPosition = j;
            for (int s = j + 1; s < sortedArray.GetLength(1); s++)
            {
                if (sortedArray[i, s] > sortedArray[i, maxPosition])
                {
                    maxPosition = s;
                }

                int temp = sortedArray[i, j];
                sortedArray[i,j] = sortedArray[i, maxPosition];
                sortedArray[i, maxPosition] = temp;
            }

        }
    }
    return sortedArray;
}


// Code
Console.WriteLine("Введите количество строк массива");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns);
Console.WriteLine("Ваш массив:");
PrintArray(array);
Console.WriteLine("Ваш массив c упорядоченными по убыванию элементами каждой строки:");
PrintArray(SortArray(array));