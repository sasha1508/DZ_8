// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int m = 2;
int n = 2;
int l = 2;

int[,,] array = new int[m, n, l];

// заполнение массива неповторяющимися числами:
for(int i = 0; i < m; i++)
{
    
    for(int j = 0; j < n; j++)
    {
        for(int k = 0; k < l; k++)
        {
            int temp = 0;
            bool cont = true;
            do
            {
                temp = new Random().Next(10, 100);
                cont = Contains(array, temp);
                if (cont == false)    array[i, j, k] = temp;
            }while(cont);
        }
    }
}

PrintArray(array);

//Проверка наличия числа в массиве
bool Contains(int[,,] array1, int number)
{
    int m = array1.GetLength(0);
    int n = array1.GetLength(1);
    int l = array1.GetLength(2);
    
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            for(int k = 0; k < l; k++)
            {
                if(array1[i,j,k] == number) 
                {
                    return true;
                }
            }
        }
    }
    return false;
}

void PrintArray(int[,,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            for(int k = 0; k < l; k++)
            {
                System.Console.Write($"{array[i,j,k]}({i},{j},{k})  ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}