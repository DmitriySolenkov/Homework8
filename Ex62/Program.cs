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

int Prompt(string message)
{
    Console.Write(message);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

int length=Prompt("Введите сторону спирального массива:");
int[,] matrix = new int[length,length];//Я помню про KISS и YAGNI,просто было интересно, смогу ли я написать программу не строго для 4х4         
int ratio = 1;
int count = 0;
int lineCount = 0;
int columnCount = 0;

while (count < matrix.GetLength(0) + matrix.GetLength(1))
{

    for (int i = columnCount; i < matrix.GetLength(1) - columnCount; i++)
    {
        matrix[lineCount, i] = ratio;
        ratio++;
    }
    count++;
    columnCount++;

    for (int i = columnCount; i < matrix.GetLength(0) - lineCount; i++)
    {
        matrix[i, matrix.GetLength(1) - columnCount] = ratio;
        ratio++;
    }
    count++;
    lineCount++;

    for (int i = matrix.GetLength(1) - lineCount - 1; i >= columnCount - 1; i--)
    {
        matrix[matrix.GetLength(0) - columnCount, i] = ratio;
        ratio++;
    }
    count++;
    if (count < matrix.GetLength(0) + matrix.GetLength(1) - 1)
    {
        for (int i = matrix.GetLength(0) - lineCount - 1; i > columnCount - 1; i--)
        {
            matrix[i, columnCount-1] = ratio;
            ratio++;
        }
    }
    count++;



}



PrintMatrix(matrix);