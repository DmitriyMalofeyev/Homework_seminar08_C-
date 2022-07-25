// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.



Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.Write("ВВедите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GerArray (int m, int n, int minRandom, int maxRandom)
{
    int[,] result = new int[m, n];   // табличка - матрица (m на n)
    for (int i = 0; i < result.GetLength(0); i++)  // цикл по строчкам     0 - m (строчки)  1 - n (столбцы)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(minRandom, maxRandom + 1); // [)
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

void SortRows(int [,] matrix)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}
SortRows(array);

Console.WriteLine("Отсортированный массив: ");
PrintArray(array);
