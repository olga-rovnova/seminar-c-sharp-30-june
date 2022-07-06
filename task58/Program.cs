// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

int m = new Random().Next(5);
int[,] tableOne = new int[m, m];
int[,] tableTwo = new int[m, m];
int[,] result = new int[m, m];   

FillArray(tableOne); 
FillArray(tableTwo); 
PrintArray(tableOne); 
Console.WriteLine(); 
PrintArray(tableTwo); 
Console.WriteLine();   

for (int i = 0; i < tableOne.GetLength(0); i++) 
{           
    for (int j = 0; j < tableOne.GetLength(1); j++)     
    {         
        for (int k = 0; k < tableOne.GetLength(0); k++)         {
            result[i,j] += tableOne[i,k] * tableTwo[k, j];
        }
    }
}
PrintArray(result); 

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