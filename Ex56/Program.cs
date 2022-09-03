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

int[] FillZeroArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = 0;
    }
    return array;
}

int line = Prompt("Введите число строк: ");
int column = Prompt("Введите число колонок: ");
if (line > 0 && column > 0)
{
    int[,] matrix = FillMatrix(line, column);
    PrintMatrix(matrix);
    Console.WriteLine();
    int[] sumArray = FillZeroArray(line);

    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            sumArray[i] += matrix[i, j];
        }
    }

    int maxSum = sumArray[0];
    int maxSumLine = 0;
    for (int i = 0; i < line; i++)
    {
        if (sumArray[i] > maxSum)
        {
            maxSum = sumArray[i];
            maxSumLine = i;
        }
    }

    Console.WriteLine($"Наибольшая сумма элементов в {maxSumLine + 1} строке!");

}
else
{
    Console.WriteLine("Введите корректное число строк и столбцов!");
}