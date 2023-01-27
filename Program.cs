/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

/*int[,] myArray = GetArray(3, 4);
PrintArray(myArray);
Console.WriteLine();
ResultArray(myArray);
Console.WriteLine();
PrintArray(myArray);*/


//--------методы----------

int[,] GetArray(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


/*void ResultArray(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(0), array.GetLength(1)];
      
    for (int i = 0; i < array.GetLength(0); i++)
    {                   
         for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int m = 0; m < array.GetLength(1) - 1; m++)
            {
                if (array[i, m] < array[i, m + 1])
                {
                    int temp = array[i, m + 1];
                    array[i, m + 1] = array[i, m];
                    array[i, m] = temp;
        }
            }
    }
    }
}*/

/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка*/

/*int[,] myArray = GetArray(3, 4);
PrintArray(myArray);
Console.WriteLine();
MinSumElements(myArray);

void MinSumElements(int[,] array)
{
    int minNum = 0;
    int minSum = 0;
    int sumNum = 0;
    for (int i = 0; i < myArray.GetLength(1); i++)
    {
        minNum += myArray[0, i];
    }
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++) sumNum += myArray[i, j];
        if (sumNum < minNum)
        {
            minNum = sumNum;
            minSum = i;
        }
        sumNum = 0;
    }
    Console.Write($"{minSum + 1} строка");
}*/

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] myArray = GetArray(2, 2);
PrintArray(myArray);
Console.WriteLine();
int[,] myArray2 = GetArray2(2, 2);
PrintArray(myArray2);
int[,] resultArray = new int [2,2];
SummArray(myArray, myArray2, resultArray);
Console.WriteLine($"Произведение 2x матриц:");
PrintArray(resultArray);

int[,] GetArray2(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void SummArray(int[,] myArray, int[,] myArray2, int[,] resultArray)
{
  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < myArray.GetLength(1); k++)
      {
        sum += myArray[i,k] * myArray2[k,j];
      }
      resultArray[i,j] = sum;
    }
  }
}