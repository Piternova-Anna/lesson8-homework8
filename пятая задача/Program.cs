// Напишите программу, которая заполнит спирально массив 4 на 4. 
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

int rows = 4;
int colums = 4;
int[,] array = new int[rows, colums];


int k = new Random().Next(0, 100);

for (int j = 0; j < array.GetLength(1); j++)
{
    array[0, j] = k;
    k++;
}

for (int i = 1; i < array.GetLength(0); i++)
{
    array[i, array.GetLength(1) - 1] = k;
    k++;
}

for (int j = 2; j >= 0; j--)
{
    array[array.GetLength(0) - 1, j] = k;
    k++;
}

for (int i = 2; i > 0; i--)
{
    array[i, 0] = k;
    k++;
}

for (int j = 1; j < array.GetLength(1) - 1; j++)
{
    array[array.GetLength(0) - 3, j] = k;
    k++;
}

for (int j = 2; j > 0; j--)
{
    array[array.GetLength(0) - 2, j] = k;
    k++;
}
Console.WriteLine("Массив 4 на 4 заполненый спирально:");
PrintArray(array);