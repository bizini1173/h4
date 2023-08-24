// Задача 52.
//  Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] CalculatAverages(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    double[] averages = new double[columns];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        averages[j] = sum / rows;
    }

    return averages;
}

void PrintAverages(double[] averages)
{
    foreach (var average in averages)
    {
        Console.WriteLine(average.ToString("0.0"));
    }
}

    int[,] matrix = CreateMatrixRndInt(3, 4, 1, 10);
    Console.WriteLine("Задан массив: ");
    PrintMatrix(matrix);

    double[] columnAverages = CalculatAverages(matrix);
    Console.WriteLine("\nСреднее арифметическое значение в каждом столбце: ");
    PrintAverages(columnAverages);

