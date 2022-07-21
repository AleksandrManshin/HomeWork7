// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.

void Zadacha50()
{
     Random random = new Random();
    int rows = random.Next(4, 9);
    int columns = random.Next(4, 9);
    int [,] array = new int [rows, columns];
   
    FillArray(array);
    PrintArray(array);

     Console.WriteLine("Введите номер строки: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбика: ");
    int column = Convert.ToInt32(Console.ReadLine());
    if(rows < row || columns < column)
    {
        Console.WriteLine("Такой позиции не существует.");
    }
    Console.WriteLine();
    Console.WriteLine($"Элемент на позиции [{row}, {column}] = {array[row-1, column-1]}");
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

Zadacha50();
