// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.

void Zadacha52()
{
    Random random = new Random();
    int rows = random.Next(4, 9);
    int columns = random.Next(4, 9);
    int [,] array = new int [rows, columns];
   
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    ArithmeticMean(array);
}

void FillArray(int [,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int count = 0;

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array [i, j] = random.Next(1, 10);
            count++;
        }
    }
}

void PrintArray(int [,] array)
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

void ArithmeticMean(int [,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int j = 0; j < columns; j++)
    {
        double sum = 0;
        double result = 0;
        for(int i = 0; i < rows; i++)
        {
             sum += array[i, j];
             
        }
         result = Math.Round(sum / rows, 1);
         Console.WriteLine($"среднее арифметическое чисел столбца {j+1} = {result}");
    }
}

Zadacha52();