// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

for(int k = 0; k < m; k++)
{ 
    BubbleSort(array, k, n);
}

// Отображение масива в консоле:
System.Console.WriteLine($"Отсортированный массив [{m}, {n}]:");
PrintArray(array);


void BubbleSort(int[,] array, int k, int n)
{
	for (int i = 0; i < n; i++)
		for (int j = 0; j < n - 1; j++)
			if (array[k, j] < array[k, j + 1])
			{
				int t = array[k,j + 1];
				array[k, j + 1] = array[k, j];
				array[k, j] = t;
			}
}

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
