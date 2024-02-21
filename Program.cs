// Two-dimensional arrays

Console.WriteLine("Task 53");
// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

Console.Write("Enter a number of rows: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a number of columns: ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[x, y];

void CreateArray()
{
    for (int row=0; row<matrix.GetLength(0); row++)
    {
        for (int column=0; column<matrix.GetLength(1); column++)
        {
            matrix[row, column] = new Random().Next(-10, 11);
        }
    }
}

void PrintArray()
{
    for (int row=0; row<matrix.GetLength(0); row++)
    {
        for (int column=0; column<matrix.GetLength(1); column++)
        {
            Console.Write(matrix[row, column] + " ");
        }
        Console.WriteLine();
    }
}

// Swapping the lines
void SwapTheLines()
{
    for (int column=0; column<matrix.GetLength(1); column++)
    {
        int changer = matrix.GetLength(0)-1;    // index of the last row
        int temp = matrix[0, column];
        matrix[0, column] = matrix[changer, column];
        matrix[changer, column] = temp;
    }
}

Console.WriteLine("Before: ");
CreateArray();
PrintArray();
SwapTheLines();
Console.WriteLine("After: ");
PrintArray();


Console.WriteLine("\nTask 55");
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для пользователя.

Console.Write("Enter the number of rows and columns for the square array: ");
int number = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[number, number];
int[,] matrix2 = new int[number, number];

void CreateSquareArray()
{
    for (int row=0; row<matrix1.GetLength(0); row++)
    {
        for (int column=0; column<matrix1.GetLength(1); column++)
        {
            matrix1[row, column] = new Random().Next(-10, 11);
        }
    }
}

void PrintSquareArray(int[,] array)
{
    for (int row=0; row<array.GetLength(0); row++)
    {
        for (int column=0; column<array.GetLength(1); column++)
        {
            Console.Write(array[row, column] + " ");
        }
        Console.WriteLine();
    }
}

void SwapRowColumn()
{
    for (int row=0; row<matrix2.GetLength(0); row++)
    {
        for (int column=0; column<matrix2.GetLength(1); column++)
        {
            matrix2[row, column] = matrix1[column, row];
        }
    }
}

Console.WriteLine("Before: ");
CreateSquareArray();
PrintSquareArray(matrix1);
Console.WriteLine("After: ");
SwapRowColumn();
PrintSquareArray(matrix2);


Console.WriteLine("\nTask 59");
