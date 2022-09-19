// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] FillArray(int row, int colums)
{
    int[,] array = new int[row, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
    return array;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int rows1 = new Random().Next(2,10);
Console.WriteLine("количество строк 1 матрицы:  "+rows1);
int colums1= new Random().Next(2,10);
Console.WriteLine("количество столбцов 1 матрицы: "+colums1);
int[,] array1 = FillArray(rows1, colums1);
Console.WriteLine("матрица 1: ");
PrintArray(array1);
Console.WriteLine();

int rows2 = colums1 ;
Console.WriteLine("количество строк 2 матрицы: "+rows2);
int colums2= new Random().Next(2,10);
Console.WriteLine("количество столбцов 2 матрицы:  "+colums2);
int[,] array2 = FillArray(rows2, colums2);
Console.WriteLine("матрица 2: ");
PrintArray(array2);
Console.WriteLine();

int[,] PowArray = new int[array1.GetLength(0), array2.GetLength(1)];

for (int i = 0; i < PowArray.GetLength(0); i++)
{
    for (int j = 0; j < PowArray.GetLength(1); j++)
    {
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            PowArray[i, j] += array1[i, k] * array2[k, j];
        }
    }
}

Console.WriteLine("Произведение двух матриц: ");
PrintArray(PowArray);