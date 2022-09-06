//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
/*
int[,] CreateArray(int str, int col)
{
    int[,] array = new int[str, col];
    Random rnd = new Random();
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rnd.Next(0,9);
        }
    }
    return array;
}

int[,] WriteArr(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
            Console.Write(array2[i,j] + " ");
        Console.WriteLine();
    }
    return array2;
}

void Puzzle(int[,] array3)
{
    int n = array3.GetLength(1);
    int temp = 0;
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            int k = 0;
            for (k = 0; k < n-1; k++)
            {
                if (array3[j, k] < array3[j, k+1])
                {
                    temp = array3[j, k];
                    array3[j, k] = array3[j, k+1];
                    array3[j, k+1] = temp;
                }
            }
        }        
    }
    Console.WriteLine();
    Console.WriteLine("Puzzled array:");

    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
            Console.Write(array3[i,j] + " ");
        Console.WriteLine();
    }
}

Console.Write("Please input number of array's strings: ");
int strings = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input number of array's columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Puzzle(WriteArr(CreateArray(strings, columns)));
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int[,] CreateArray(int str, int col)
{
    int[,] array = new int[str, col];
    Random rnd = new Random();
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rnd.Next(0,9);
        }
    }
    return array;
}

int IndexOfString(int[] array3)
{
    int min = array3[0];
    int minInd = 0;
    for (int i = 0; i < array3.Length; i++)
    {
        Console.Write(array3[i] + " ");
        if (array3[i] <= min)
        {
            min = array3[i];
            minInd = i;
        }        
    }
    return minInd;
}

void SumString(int[,] array2)
{
    
    int[] sum = new int[array2.GetLength(0)];
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write($"{array2[i, j]}  ");
            sum[i] += array2[i, j]; 
        }
        Console.WriteLine($" sum is = {sum[i]}  ");     
    }
    
    Console.WriteLine($"Index of string with min sum is {IndexOfString(sum)}  ");     
}

Console.Write("Please input number of array's strings: ");
int strings = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input number of array's columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

SumString(CreateArray(strings, columns));
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
/*
int[][,] CreateArray(int str1, int col1, int str2, int col2)
{
    int[,] array1 = new int[str1, col1];
    int[,] array2 = new int[str2, col2];
    Random rnd = new Random();
    for (int i = 0; i < str1; i++)
    {
        for (int j = 0; j < col1; j++)
        {
            array1[i, j] = rnd.Next(0,9);
            Console.Write(array1[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < str2; i++)
    {
        for (int j = 0; j < col2; j++)
        {
            array2[i, j] = rnd.Next(0,9);
            Console.Write(array2[i,j] + " ");
        }
        Console.WriteLine();
    }      
    int[][,] arrayArr = new int[2][,];
    arrayArr[0] = array1;
    arrayArr[1] = array2;
    return arrayArr;
}

void MatrixProduct(int[][,] array)
{
    int[,] product = new int[array[0].GetLength(1), array[1].GetLength(1)];
    Console.WriteLine();
    
    for (int k = 0; k < array[1].GetLength(1); k++)
    {
        for (int i = 0; i < array[0].GetLength(0); i++)
        {
            for (int j = 0; j < array[0].GetLength(1); j++)
            {
                product[i,k] += array[0][i,j]*array[1][j,k];
               
            }
            Console.Write(product[i, k] + " ");            
        }
        Console.WriteLine();    
    }
}

Console.Write("Please input number of 1 array's strings: ");
int strings1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input number of 1 array's columns: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input number of 2 array's strings: ");
int strings2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input number of 2 array's columns: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

if (columns1 != strings2) Console.Write("Incorrect sizes of matrixes. Please input number of 1 array columns equal to number of 2 array strings");
    else MatrixProduct(CreateArray(strings1, columns1, strings2, columns2));
*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
/*
void CreateArray(int str, int col, int dim)
{   
    int prod = str * col * dim;
    int[,,] array = new int[str, col, dim];
    
    int temp = 0;
    int[] tempArray = new int[prod];
    Random rnd = new Random();
    tempArray[0] = rnd.Next(10,99);

    for (int i = 1; i < prod; i++)
    {
        temp = rnd.Next(10,99);
            for (int j = i-1; (j < i & j >= 0); j--)
            {
                if (temp == tempArray[j]) 
                {
                    temp = rnd.Next(10,99);
                    j = i;
                }
            }     
        tempArray [i] = temp;
        //Console.Write(tempArray[i - 1] + " ");
    }
    Console.WriteLine();
    temp = 0;
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < dim; k++)
            {
                array[i, j, k] = tempArray[temp];
                temp++;
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Please input the 1st size of array: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input the 2nd size of array: ");
int size2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input the 3rd size of array: ");
int size3 = Convert.ToInt32(Console.ReadLine());

int product = size1 * size2 * size3;
if (product < 99 & product > 0) CreateArray(size1, size2, size3);
    else Console.Write("Incorrect sizes");
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
