// В прямоугольной матрице найти строку с наименьшей суммой элементов.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
int FindMinSumRow(int[,] matr)
{
    int tmp = 9999;
    int row = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int sum = 0;
            sum = sum + matr[i,j];
            //Console.WriteLine($"{j} == 1 / {tmp} >= {sum}");
            if (j == (matr.GetLength(1) - 1) && tmp >= sum)
            {
                // Console.WriteLine($"{sum}");
                tmp = sum;
                sum = 0;
                row = i + 1;
            }
        }
    }
    return row;
}

Console.WriteLine("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
int rowsum = FindMinSumRow(matrix);
Console.WriteLine($"Строка с минимальной суммой элементов: {rowsum}");

