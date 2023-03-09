// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int[,] matrix1 = {{2, 4}, {3, 2}};
int[,] matrix2 = {{3, 4}, {3, 3}};

System.Console.WriteLine("Матрица 1:");
PrintArray(matrix1);

System.Console.WriteLine("Матрица 2:");
PrintArray(matrix2);

int[,] matrixMultiplication = new int[2,2];

matrixMultiplication[0,0] = matrix1[0,0] * matrix2[0,0] + matrix1[0,1] * matrix2[1,0];
matrixMultiplication[0,1] = matrix1[0,0] * matrix2[0,1] + matrix1[0,1] * matrix2[1,1];
matrixMultiplication[1,0] = matrix1[1,0] * matrix2[0,0] + matrix1[1,1] * matrix2[1,0];
matrixMultiplication[1,1] = matrix1[1,0] * matrix2[0,1] + matrix1[1,1] * matrix2[1,1];

System.Console.WriteLine("Произведение матриц:");
PrintArray(matrixMultiplication);

void PrintArray(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            System.Console.Write($"{array[i,j]}  ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}