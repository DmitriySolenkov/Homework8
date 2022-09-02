int[,] FillMatrix(int length1, int length2)
{
    int[,] array = new int[length1, length2];
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
    return array;
}

int[,] FillZeroMatrix(int length1, int length2)
{
    int[,] array = new int[length1, length2];
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            array[i, j] = 0;
        }
    }
    return array;
}

int Prompt(string message)
{
    Console.Write(message);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

void PrintMatrix(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write($"{matrix[k, l]}\t");
        }
        Console.WriteLine();
    }
}

int line = Prompt("Введите число строк: ");
int column = Prompt("Введите число колонок: ");
if (line > 0 && line == column)
{
    int[,] matrix = FillMatrix(line, column);
    PrintMatrix(matrix);
    Console.WriteLine();
    int min = matrix[0, 0];
    int minLine = 0;
    int minColumn = 0;

    for (int l = 0; l < line; l++)
    {
        for (int m = 0; m < column; m++)
        {
            if (matrix[l, m] < min)
            {
                min = matrix[l, m];
                minLine = l;
                minColumn = m;
            }
        }
    }

    int [,] modifiedMatrix = FillZeroMatrix(line - 1, column - 1);

    for (int l = 0; l < minLine; l++)
    {
        for (int m = 0; m < minColumn; m++)
        {
            modifiedMatrix[l, m] = matrix[l, m];
        }
    }

    for (int l = 0; l < minLine; l++)
    {
        for (int m = minColumn + 1; m < column; m++)
        {
            modifiedMatrix[l, m - 1] = matrix[l, m];
        }
    }

    for (int l = minLine + 1; l < line; l++)
    {
        for (int m = 0; m < minColumn; m++)
        {
            modifiedMatrix[l - 1, m] = matrix[l, m];
        }
    }
    for (int l = minLine + 1; l < line; l++)
    {
        for (int m = minColumn + 1; m < column; m++)
        {
            modifiedMatrix[l - 1, m - 1] = matrix[l, m];
        }
    }

    PrintMatrix(modifiedMatrix);
}
else
{
    Console.WriteLine("Введите равное и корректоное число строк и столбцов для замены!");
}