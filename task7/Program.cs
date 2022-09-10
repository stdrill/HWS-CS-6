// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно 


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
void ChangeRowsCol(int[,] matr)
{
   for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
          if(i != j && j > i)
          {
            int tmp = matr[i,j];
            matr[i,j] = matr[j,i];
            matr[j,i] = tmp;
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
if (m == n)
{
ChangeRowsCol(matrix);
Console.WriteLine();
PrintArray(matrix);
}
else 
{
Console.WriteLine("Количество строк и столбцов не совпадает. ");
}
