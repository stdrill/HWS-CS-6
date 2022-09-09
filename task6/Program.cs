// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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
void SortRows(int[,] matr)
{
    for (int r = 0; r < matr.GetLength(0); r++)
    {
        for (int i = 0; i < matr.GetLength(1); i++)
        {
            for (int j = matr.GetLength(1) - 1; j > i; j--){
                if (matr[r, j] > matr[r, j - 1])
                {
                    int tmp = matr[r, j];
                    matr[r, j] = matr[r, j - 1];
                    matr[r, j - 1] = tmp;
                }
            }
        }
    }
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
SortRows(matrix);
PrintArray(matrix);
