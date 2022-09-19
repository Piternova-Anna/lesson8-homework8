// .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int RepeatChek(int position1, int position2, int position3, int[,,] array)
{
    int replay = 0;
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == position1 && j == position2 && k == position3)
                {
                    continue;
                }
                if (array[position1, position2, position3] == array[i, j, k])
                {
                    replay = 1;
                    return replay;
                }
            }
        }
    }
    return replay;
}


int height = new Random().Next(2,5);
Console.WriteLine("высота: "+height);
int width = new Random().Next(2,5);
Console.WriteLine("ширина: "+width);
int depth = new Random().Next(2,5);
Console.WriteLine("глубина: "+depth);
int[,,] massiv = new int[height, width, depth];

for (int k = 0; k < massiv.GetLength(2); k++)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j, k] = new Random().Next(10, 100);
            int replay = RepeatChek(i, j, k, massiv);
            while (replay == 1)
            {
                massiv[i, j, k] = new Random().Next(10, 100);
                replay = RepeatChek(i, j, k, massiv);
            }
        }
    }
}

for (int k = 0; k < massiv.GetLength(2); k++)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write(massiv[i,j,k]+"("+i+","+j+","+k+") ");
        }
        Console.WriteLine();
    }
}