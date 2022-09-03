int[,,] FillMatrix2(int length1, int length2, int length3)
{
    int ratio = 0;
    int[,,] array = new int[length1, length2, length3];
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            for (int k = 0; k < length3; k++)
            {
                array[i, j, k] = new Random().Next(1, 6) + ratio;
                ratio += 5;
            }

        }
    }
    return array;
}

void PrintMatrix2(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            for (int m = 0; m < matrix.GetLength(2); m++)
            {
                Console.Write($"{matrix[k, l, m]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


int[,,] matrix = FillMatrix2(2, 2, 2); //2- это не магическое число, это ТЗ:(массив 2х2х2)
PrintMatrix2(matrix);
Console.WriteLine();


for (int k = 0; k < matrix.GetLength(0); k++)
{
    for (int l = 0; l < matrix.GetLength(1); l++)
    {
        for (int m = 0; m < matrix.GetLength(2); m++)
        {
            Console.WriteLine($"{matrix[k, l, m]}({k},{l},{m})");
        }
    }
}