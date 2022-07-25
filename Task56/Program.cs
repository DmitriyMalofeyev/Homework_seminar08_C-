// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

startProgramm:
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.Write("ВВедите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
if (rows == columns)
{
    Console.WriteLine("Число строк не может быть равно числу столбцов. Требуется ввести прямоугольный массив");
    goto startProgramm;
}

int[,] GerArray (int m, int n, int minRandom, int maxRandom)
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

int[,] array = GerArray(rows, columns, -10, 10);


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

Console.WriteLine("Задан массив: ");
PrintArray(array);


int SumNumbersRow (int [,] matrix)
{
    int sumRow = 0;
    int minSumRow = 0;
    int minIndexRow = 0; 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
        }
        if (i == 0) minSumRow = sumRow;
        if (sumRow <= minSumRow) 
        {
            minIndexRow = i + 1;
            minSumRow = sumRow;
        }
        sumRow = 0;
    }
    return  minIndexRow;
}


int result = SumNumbersRow (array);

Console.WriteLine("Номер строки с минимальной суммой элементов: " + result);


