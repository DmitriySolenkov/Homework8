//Программа для матриц с одинаковыми строками и столбцами
//Мог бы написать для полностью разных матриц, но голова и так сломалась(

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

int[,] FillZeroScalarMatrix(int length)
{
    int[,] array = new int[length, length];
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
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

int ScalarSum(int lineInd, int columnInd, int[,] matrix1, int[,] matrix2, int size)
{
    int scalarSum = 0;
    for (int i = 0; i < size; i++)
    {
        scalarSum += matrix2[lineInd, i] * matrix1[i, columnInd];
    }
    return scalarSum;

}


int line = Prompt("Введите число строк: ");
int column = Prompt("Введите число колонок: ");
if (line > 0 && column > 0)
{
    int maxLength = 0;
    int minLength = 0;
    if (line >= column)
    {
        maxLength = line;
        minLength = column;
    }
    else
    {
        maxLength = column;
        minLength = line;
    }

    int[,] matrix1 = FillMatrix(minLength, maxLength);
    PrintMatrix(matrix1);
    Console.WriteLine();
    int[,] matrix2 = FillMatrix(maxLength, minLength);
    PrintMatrix(matrix2);
    Console.WriteLine();
    int[,] scalarMatrix = FillZeroScalarMatrix(maxLength);

    for (int i = 0; i < maxLength; i++)
    {
        for (int j = 0; j < maxLength; j++)
        {
            scalarMatrix[i, j] = ScalarSum(i, j, matrix1, matrix2, minLength);
        }
    }

    PrintMatrix(scalarMatrix);

}
else
{
    Console.WriteLine("Введите корректное число строк и столбцов!");
}