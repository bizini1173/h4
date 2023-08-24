// // Задача 50. Напишите программу, 
// // которая на вход принимает позиции элемента в двумерном массиве,
// //  и возвращает значение этого элемента или же указание, что такого элемента нет.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 1,7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}
bool TryGetElement(int[,] matrix, int row, int column, out int element)
{
    element = 0;

    if (row >= 0 && row < matrix.GetLength(0) && column >= 0 && column < matrix.GetLength(1))
    {
        element = matrix[row, column];
        return true;
    }

    return false;
}

int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);

int targetRow = 1;
int targetColumn = 2;

if (TryGetElement(array2d, targetRow, targetColumn, out int result))
{
    Console.WriteLine($"Элемент на позиции ({targetRow}, {targetColumn}): {result}");
}
else
{
    Console.WriteLine($"Такого элемента в массиве нет  ({targetRow}, {targetColumn}).");
}

