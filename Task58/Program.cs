// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите количество строк массивов: ");
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.Write("ВВедите количество столбцов массивов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray (int m, int n, int minRandom, int maxRandom)
{
    int[,] result = new int[m, n];   
    for (int i = 0; i < result.GetLength(0); i++)  
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(minRandom, maxRandom + 1); 
        }
          
    }
    return result;  
}

int[,] arrayOne = GetArray(rows, columns, -10, 10); // определяем диапазон случайных чисел массива 1 от -10 до 10
int[,] arrayTwo = GetArray(rows, columns, -20, 20); // определяем диапазон случайных чисел массива 1 от -20 до 20


void PrintArray (int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)  
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i,j] + "\t");    
        }
    Console.WriteLine("\n");      
    }
}

Console.WriteLine("Задан массив 1: ");
PrintArray(arrayOne);
Console.WriteLine("Задан массив 2: ");
PrintArray(arrayTwo);

int[,] ProductArray (int[,] matrixOne, int[,] matrixTwo)
{
    int[,] resultProductArray = new int[rows, columns];
    for (int i = 0; i < resultProductArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultProductArray.GetLength(1); j++)
        {
            resultProductArray[i, j] = matrixOne[i, j] * matrixTwo[i, j];
        }
    }
    return resultProductArray;
}

Console.WriteLine("Результат произведения массивов: ");
int[,] arraysProduct = ProductArray(arrayOne, arrayTwo);
PrintArray(arraysProduct);
