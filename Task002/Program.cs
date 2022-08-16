// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// Method


int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] localArray)
{
    for (int i = 0; i < localArray.GetLength(0); i++)
    {
        for (int j = 0; j < localArray.GetLength(1); j++)
        {
            Console.Write($"{localArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}


int[] FindSumOfElements(int[,] arr)
{

    int size = arr.GetLength(0);
    int[] sumOfElements = new int[size];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        sumOfElements[i] = sum;
    }
    return sumOfElements;
}

int FindMinPosition (int [] lineOfSums)
{
    int minPosition = 0;
    for (int i = 0; i < lineOfSums.Length; i++)
    {
        if (lineOfSums[i] < lineOfSums[minPosition])
        {
            minPosition = i;
        }

    }
    return minPosition;
}


//Code

Console.WriteLine("Введите количество строк:");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = int.Parse(Console.ReadLine());
int[,] myArray = GetArray(rows, columns, 0, 11);
Console.WriteLine("Ваш массив:");
PrintArray(myArray);

Console.WriteLine("Cумма элементов в каждой строке: \n{0}", String.Join("\t", FindSumOfElements(myArray)));

int[] sumsOfLines = FindSumOfElements(myArray);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {FindMinPosition(sumsOfLines)+1}");
Console.WriteLine();