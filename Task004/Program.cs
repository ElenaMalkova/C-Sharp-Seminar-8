// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. 
// массив размером 2 x 2 x 2

// Methods

int[,,] GetArray(int a, int b, int c)
{
    int[,,] result = new int[a, b, c];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = new Random().Next(10, 100);
            }  
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}({i}{j}{k}) \t");
            } 
        }
        Console.WriteLine();
    }
}

// Code
Console.WriteLine("Введите первое измерение массива");
int firstDimension = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе измерение массива");
int secondDimension = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье измерение массива");
int thirdDimension = int.Parse(Console.ReadLine());
int[,,] array = GetArray(firstDimension, secondDimension, thirdDimension);
Console.WriteLine("Ваш массив:");
PrintArray(array);