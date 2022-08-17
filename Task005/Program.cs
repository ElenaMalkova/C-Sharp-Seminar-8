// Заполните спирально массив 4 на 4.

// Methods
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            {
                Console.Write($"{inArray[i, j]} \t");
            }
        }
        Console.WriteLine();
    }
}


int[,] FillArray(int[,] arr)
{
    int top = 0;
    int bottom = arr.GetLength(1) - 1;
    int left = 0;
    int right = arr.GetLength(0) - 1;
    int count = 0;
    int sum = 0;
    int i = 0;
    int j = 0;
    while (count < arr.GetLength(0) / 2)
    {
        for (j = left; j <= right; j++)
        {
            sum++;
            arr[top, j] = sum;
        }
        top++;

        for (i = top; i <= bottom; i++)
        {
            sum++;
            arr[i, right] = sum;
        }
        right--;

        for (j = right; j >= left; j--)
        {
            sum++;
            arr[bottom, j] = sum;
        }
        bottom--;

        for (i = bottom; i >= top; i--)
        {
            sum++;
            arr[i, left] = sum;
        }
        left++;

        count++;
    }

    return arr;
}


// Code

int[,] array = new int[4, 4];
PrintArray(FillArray(array));

