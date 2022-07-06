// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int m = new Random().Next(10);
int n = new Random().Next(10);
int[,] table = new int[m, n];
int min = int.MaxValue; 
int indexLine = 0;   

FillArray(table); 
PrintArray(table);  

for (int i = 0; i < table.GetLength(0); i++) 
{     
    int sum = 0;     
    for (int j = 0; j < table.GetLength(1); j++)     
    {         
        sum = sum + table[i, j];      
    }     
    if (sum < min)     
    {         
        min = sum;         
        indexLine = i;     
    } 
}  

Console.Write(indexLine+1); 

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
        Console.WriteLine();
    }
}