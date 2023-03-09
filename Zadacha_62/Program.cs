// ДОПОЛНИТЕЛЬНАЯ ЗАДАЧКА
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int m = 4;
int n = 4;
int index = 0;

int[,] array = new int[m, n];

// заполнение массива:
for(int i = 0; i < 4; i++)
{
    index++;
    array[0, i] = index;  
}
for(int i = 1; i < 4; i++)
{
    index++;
    array[i, 3] = index;  
}
for(int i = 1; i < 4; i++)
{
    index++;
    array[3, 3 - i] = index;  
}
for(int i = 1; i < 3; i++)
{
    index++;
    array[3 - i, 0] = index;  
}
for(int i = 1; i < 3; i++)
{
    index++;
    array[1, i] = index;  
}
for(int i = 0; i < 2; i++)
{
    index++;
    array[2, 2 - i] = index;  
}

// index++;
// array[2, 1] = index;  

PrintArray(array);


void PrintArray(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            System.Console.Write($"{array[i,j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}