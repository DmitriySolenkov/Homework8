int[,] FillMatrix(int length1, int length2, int min, int max)
{
    int[,] array = new int[length1, length2];
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
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

int[] FillDictionaryArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = i;
    }
    return array;
}

int[] FillDictionaryArrayNegative(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = -i;
    }
    return array;
}

int[] FillCountArray(int length)
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
int min = Prompt("Введите минимальное значение эелемента массива: ");
int max = Prompt("Введите максимальное значение эелемента массива: ");
if (line > 0 && column > 0)
{
    int[,] matrix = FillMatrix(line, column, min, max);
    PrintMatrix(matrix);
    Console.WriteLine();
    int[] dictionaryArray = FillDictionaryArray((line + 1) * (column + 1));
    int[] countArray = FillCountArray((line + 1) * (column + 1));
    int[] dictionaryArrayNegative = FillDictionaryArrayNegative((line + 1) * (column + 1));
    int[] countArrayNegative = FillCountArray((line + 1) * (column + 1));

    for (int l = 0; l < line; l++)
    {
        for (int m = 0; m < column; m++)
        {
            for (int n = 0; n < dictionaryArray.GetLength(0); n++)
            {
                if (matrix[l, m] == dictionaryArray[n])
                {
                    countArray[n]++;
                }
                if (matrix[l, m] == dictionaryArrayNegative[n])
                {
                    countArrayNegative[n]++;
                }
            }
        }
    }

    for (int i = 1; i < dictionaryArrayNegative.GetLength(0); i++)
    {
        if (countArrayNegative[i] > 0)
        {
            Console.WriteLine($"Число {dictionaryArrayNegative[i]} встречается {countArrayNegative[i]} раз!");
        }
    }
    for (int i = 0; i < dictionaryArray.GetLength(0); i++)
    {
        if (countArray[i] > 0)
        {
            Console.WriteLine($"Число {dictionaryArray[i]} встречается {countArray[i]} раз!");
        }
    }

}
else
{
    Console.WriteLine("Неверные значения!");
}