// Написать программу, которая обменивает элементы первой строки и последней строки

void PrintArray (double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++){
        for(int j = 0; j < matr.GetLength(1); j++){
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray (double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++){
        for(int j = 0; j < matr.GetLength(1); j++){
            matr[i, j] = new Random().Next(1,10);
        }
    }   
}
void ChangeRows (double[,] matr)
{
    double[] row = new double[matr.GetLength(1)];
        for(int j = 0; j < matr.GetLength(1); j++){
                row[j] = matr[0,j];
                matr[0,j] = matr[matr.GetLength(0)-1,j];
                matr[matr.GetLength(0)-1,j] = row[j];
            }
    }

Console.WriteLine("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m, n];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
ChangeRows(matrix);
Console.WriteLine();
PrintArray(matrix);
