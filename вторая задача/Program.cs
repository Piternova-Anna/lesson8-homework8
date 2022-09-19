// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void GetArray(int[,]array, int rows, int colums)
{
    for (int j = 0; j < rows; j++)
    {
        for (int i = 0; i < colums; i++)
        {
            array[i,j]=new Random().Next(10, 100);
            Console.Write(array[i,j] +"|");
        }
        Console.WriteLine();
    } 
}


Console.WriteLine("введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
int colums = rows+1;
Console.WriteLine("количество столбцов: "+colums);
int[,]massiv =new int[colums,rows];
GetArray(massiv,rows,colums);
Console.WriteLine("суммы элементов в строках: ");

int size=rows;
int[]StringSumArray =new int[size];
    for (int j = 0; j < rows; j++)
    {
        int StringSum=0;
        for (int i = 0; i < colums; i++)
        {
            StringSum=StringSum+massiv[i,j];
        } 
        StringSumArray[j]=StringSum;
        Console.Write(StringSumArray[j]+" ");
    }

int jmin=0;
int minStringSumArray=StringSumArray[jmin];
Console.WriteLine();
for (int j = 1; j < size; j++)
    {
        if (StringSumArray[j] < minStringSumArray)
        {
            minStringSumArray=StringSumArray[j];
            jmin = j+1;
        }  
    
    }
Console.WriteLine("наименьшая сумма элементов ( "+minStringSumArray+" ) в строке № "+jmin);