// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

Console.Clear();

int m = 3;
int n = 4;

int[,] array = new int[m, n];

// заполнение массива:
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(100); //заполнение ячейки массива целыми числами от 0 до 99
    }
}

// Отображение масива в консоле:
System.Console.WriteLine($"Заполненный массив [{m}, {n}]:");
PrintArray(array);

int summa = Sum(array, 1);
int min = summa;
int number = 0;
for(int i = 0; i < m; i++)
{
    summa = Sum(array, i);
    if(summa < min)  
    {
        min = summa;
        number = i+1;
    }
}

System.Console.WriteLine($"Строка с наименьшей суммой: {number}, сумма: {min}");

int Sum(int[,] array, int m)
{
    int sum = 0;
    int n = array.GetLength(1);
    for(int i = 0; i < n; i++)
    {
        sum = sum + array[m, i];
    }
    return sum;
}

void PrintArray(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);

    for(int i = 0; i < m; i++)
    {
        System.Console.Write($"{i+1}:\t");
        for(int j = 0; j < n; j++)
        {
            System.Console.Write($"{array[i,j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}