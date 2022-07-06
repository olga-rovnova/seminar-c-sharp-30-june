// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int m = new Random().Next(10);
int n = new Random().Next(10);
int[,] randomNumbers = new int[m, n];
FillArray(randomNumbers);
PrintArray(randomNumbers);

Console.WriteLine();

for (int k = 0; k < randomNumbers.GetLongLength(1); k++)
{

    for (int i = 0; i < randomNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < randomNumbers.GetLength(1)-1; j++)
        {
            if (randomNumbers[i, j] < randomNumbers[i, j + 1])
            {
                int temp = randomNumbers[i, j];
                randomNumbers[i, j] = randomNumbers[i, j + 1];
                randomNumbers[i, j + 1] = temp;
            }

        }
    }
}
    
    PrintArray(randomNumbers);

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