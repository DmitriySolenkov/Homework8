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

bool[,] FillBoolMatrix(int length1, int length2)
{
    bool[,] array = new bool[length1, length2];
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            array[i, j] = false;
        }
    }
    return array;
}

int line = Prompt("Введите число строк: ");
int column = Prompt("Введите число колонок: ");
if (line > 0 && line == column)
{
    int[,] matrix = FillMatrix(line, column);
    PrintMatrix(matrix);
    Console.WriteLine();
    bool[,] boolMatrix = FillBoolMatrix(line, column);
    int buffer = 0;
    for (int l = 0; l < matrix.GetLength(0); l++)
    {
        for (int m = 0; m < matrix.GetLength(0); m++)
        {
            if (boolMatrix[l, m] == false)
            {
                buffer = matrix[m, l];
                matrix[m, l] = matrix[l, m];
                matrix[l, m] = buffer;
                boolMatrix[m, l] = true;
            }
        }
    }

    PrintMatrix(matrix);

}
else
{
    Console.WriteLine("Введите равное и корректоное число строк и столбцов для замены!");
}