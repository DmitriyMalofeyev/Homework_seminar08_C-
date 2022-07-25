// Задача 62. Заполните спирально массив 4 на 4.


int n = 4;
int[,] SpriralArray = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= SpriralArray.GetLength(0) * SpriralArray.GetLength(1))
{    SpriralArray[i, j] = temp;
     temp++;
     if (i <= j + 1 && i + j < SpriralArray.GetLength(1) - 1) j++;
     else if (i < j && i + j >= SpriralArray.GetLength(0) - 1) i++;
     else if (i >= j && i + j > SpriralArray.GetLength(1) - 1) j--;
     else i--;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
            Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine($"Спиральный массив {n} на {n}: ");
PrintArray(SpriralArray);