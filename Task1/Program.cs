// Задача 47. Задайте двумерный массив размером m×n, заполненный
// случайными вещественными числами, округлёнными до одного знака.

void Zadacha47()
{   
    Random random = new Random();
    int rows = random.Next(4, 9);
    int columns = random.Next(4, 9);
    double [,] array = new double [rows, columns];

    FillArray(array);
    PrintArray(array);
}

void FillArray(double [,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array [i, j] = Math.Round(random.NextDouble() * 20 - 10, 1);
        }
    }
}

void PrintArray(double [,] array)
{
     int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Console.Write(array [i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Zadacha47();
