// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] array = new int[3, 4]
// {
//     {1, 4, 7, 2},
//     {5, 9, 2, 3},
//     {8, 4, 2, 4}
// };

// PrintArray(array);
// ChangeArray(array);
// Console.WriteLine();
// PrintArray(array);

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++ )
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} "); 
//         }
//         Console.WriteLine();
//     }
// }

// void ChangeArray (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             for (int t = j + 1; t < array.GetLength(1); t++) //if (array[i,j] > array[i,j + 1]) 
//             {
//                 if (array[i,t] > array[i,j]) // int temp = array[i,j]; 
//                                              // array[i,j] = array[i,j + 1];
//                                              // array[i,j + 1] = temp;
//                 {
//                 int temp = array[i,j]; 
//                 array[i,j] = array[i,t];
//                 array[i,t] = temp;
//                 }
//             }
//         }
//     }
// }


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);

// PrintArray(array);
// Console.WriteLine($"строка с наименьшей суммой элементов {GetRowNumber(array)}: ");

// int [,] GetArray (int m, int n, int min, int max) // генерируем рандомный массив
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//         result [i, j] = new Random().Next(min, max + 1);    
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++ )
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} "); 
//         }
//         Console.WriteLine();
//     }
// }

// int GetRowNumber (int [,] array)
// {
//     int row = 0;
//     int minsum = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minsum = minsum + array[0,i];
//     }

//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array [i,j];
//         }
//         if (minsum > sum);
//         {
//             minsum = sum;
//             row = i;
//         }
//     }
//     return row;
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.Write("Введите количество строк 1 массива: ");
// int rowsA = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов 1 массива: ");
// int columnsA = int.Parse(Console.ReadLine());

// Console.Write("Введите количество строк 2 массива: ");
// int rowsB = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов 2 массива: ");
// int columnsB = int.Parse(Console.ReadLine());
// if (columnsA != rowsB)
// {
//     Console.WriteLine ("Такие матрицы умножать нельзя");
//     return;
// }

// int[,] A = GetArray(rowsA, columnsA, 0, 10);
// int[,] B = GetArray(rowsB, columnsB, 0, 10);
// PrintArray(A);
// Console.WriteLine();
// PrintArray(B);
// Console.WriteLine();
// PrintArray(GetMultiplicationMatrix(A,B));

// int [,] GetArray (int m, int n, int min, int max) // генерируем рандомный массив
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//         result [i, j] = new Random().Next(min, max + 1);    
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++ )
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} "); 
//         }
//         Console.WriteLine();
//     }
// }

// int[,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB) // находим СУММУ произведений
// {
//     int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
//     for (int i = 0; i < arrayA.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayB.GetLength(0); j++)
//         {
//             for (int k = 0; k < arrayA.GetLength(0); k++)
//             {
//                 arrayC[i,j] += arrayA[i, k] * arrayB[k, j];
//             }
//         }
//     }
//     return arrayC;
// }


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.Write("Введите параметры массива через пробел: ");

// string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,,] array = GetArray(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]) }, 10, 99);
// PrintArray(array);

// int [,,] GetArray (int[] sizes, int min, int max) // генерируем рандомный трехмерный массив
// {
//     int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//                 int k=0;
//                 while(k < result.GetLength(2))
//             {
//                     int element = new Random().Next(min, max + 1);
//                     if(FindElement(result,element)) continue;
//                     result [i, j, k] = element;
//                     k++;    
//             }
//         }
//     }
//     return result;
// }

// bool FindElement(int[,,] array, int el)
// {
//     for (int i = 0; i < array.GetLength(0); i++)    
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if(array[i,j,k] == el) return true;
//             }
//         }    
//     }
//     return false;
// }


// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++ )
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]} ({i}, {j}, {k})   ");    
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write($"Введите размер матрицы (одно значение): ");
int s = int.Parse(Console.ReadLine());
int[,] arr = GetArray(s);
PrintArray(arr);

int[,] GetArray(int size)
{
    int[,] result = new int[size, size];
    int i = 0;
    int j = 0;
    int rowE = size - 1;
    int columnE = size - 1;
    int rowS = 0;
    int columnS = 0;
    bool left = true;
    bool top = true;
    int count = 0;
    while (count < size * size)
    {
        count++;
        result[i, j] = count;
        // вправо
        if (left && top)
        {
            if (j == columnE)
            {
                rowS++;
                top = true;
                left = false;
                i++;
                continue;
            }
            else
            {
                j++;
                continue;
            }        
        }
        // вниз
        if (!left && top)
        {
            if (i == rowE)
            {
                columnE--;
                top = false;
                left = false;
                j--;
                continue;
            }
            else
            {
                i++;
                continue;
            }
        }
        // влево
        if (!left && !top)
        {
            if (j == columnS)
            {
                rowE--;
                top = false;
                left = true;
                i--;
                continue;
            }
            else
            {
                j--;
                continue;
            }
        }
        // вверх
        if (!left && !top)
        {
            if (i == rowS)
            {
                columnS++;
                top = true;
                left = true;
                j++;
                continue;
            }
            else
            {
                i--;
                continue;
            }
        }
    }
    return result;
}







void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++ )
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} "); 
        }
        Console.WriteLine();
    }
}