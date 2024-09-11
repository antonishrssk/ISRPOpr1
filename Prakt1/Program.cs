// Выяснить сколько положительных элементов содержит матрица
// размерности n * m , если a ij = sin(i+j/2)

double[,] matrix;

Console.Write("Введите количество столбцов матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

matrix = new double[m, n];
matrix = FillAndPrintMatrix(matrix);
int count = GetPositiveElements(matrix);
Console.Write($"Количество положительных элементов: {count}");
Console.ReadKey();

int GetPositiveElements(double[,] matrix)
{
    int count = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > 0)
                count++;
        }
    }

    return count;
}

double[,] FillAndPrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Sin(i + j / 2);
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }

    return matrix;
}