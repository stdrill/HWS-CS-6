// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

void PrintArray (int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++){
        for(int j = 0; j < matr.GetLength(1); j++){
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray (int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++){
        for(int j = 0; j < matr.GetLength(1); j++){
            matr[i, j] = new Random().Next(0,10);
        }
    }   
}
void MeanColumn (int[,] matr)
{
    for(int j = 0; j < matr.GetLength(1); j++){
        double mean = 0;
        for(int i = 0; i < matr.GetLength(0); i++){
           mean = mean + matr[i,j];
        }
        mean = mean / matr.GetLength(0);
        Console.WriteLine($"Mean {mean}");
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
MeanColumn(matrix);

