// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Write("Введите ширину(x) трехмерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите высоту(y) трехмерного массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину(z) трехмерного массива: ");
int deeps = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[rows, columns, deeps];
GetArray(array);


void GetArray (int[,,] array)
{
	int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
	int  number;
	for (int i = 0; i < temp.GetLength(0); i++)
	{
		temp[i] = new Random().Next(10, 100);
		number = temp[i];
		if (i >= 1)
    		{
      			for (int j = 0; j < i; j++)
      			{
        			while (temp[i] == temp[j])
        			{
          				temp[i] = new Random().Next(10, 100);
          				j = 0;
          				number = temp[i];
        			}
          			number = temp[i];
      			}
    		}		
  	}	
  	int count = 0; 
 	for (int rows = 0; rows < array.GetLength(0); rows++)
  	{
    		for (int columns = 0; columns < array.GetLength(1); columns++)
    		{
      			for (int deeps = 0; deeps < array.GetLength(2); deeps++)
      			{
        			array[rows, columns, deeps] = temp[count];
        			count++;
     			}
    		}
 	}
}


void PrintArray (int[,,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)  
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int k = 0; k < inputArray.GetLength(2); k++)
            {
                Console.Write($"{inputArray[i, j, k]} ({i},{j},{k}); ");
            }               
        }

    Console.WriteLine("\n");      
    }
}

Console.WriteLine("Координаты элементов: ");
PrintArray(array);

