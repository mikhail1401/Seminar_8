// Two-dimensional arrays

Console.WriteLine("Task 53");
// Задача 52: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

Console.Write("Enter a number of rows: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a number of columns: ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[x, y];

int swap = 0;

Console.WriteLine("Before: ");
for (int row=0; row<matrix.GetLength(0); row++)
{
    for (int column=0; column<matrix.GetLength(1); column++)
    {
        matrix[row, column] = new Random().Next(-10, 11);
        Console.Write(matrix[row, column] + " ");
    }
    Console.WriteLine();
}

for (int column=0; column<matrix.GetLength(1); column++)
{
    int changer = matrix.GetLength(0)-1;    // index of the last row
    int temp = matrix[0, column];
    matrix[0, column] = matrix[changer, column];
    matrix[changer, column] = temp;
}

Console.WriteLine("After: ");
for (int row=0; row<matrix.GetLength(0); row++)
{
    for (int column=0; column<matrix.GetLength(1); column++)
    {
        Console.Write(matrix[row, column] + " ");
    }
    Console.WriteLine();
}


Console.WriteLine("\nTask ");