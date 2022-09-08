// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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
void ElementSquare (int[,] matr)
{
   for(int i = 0; i < matr.GetLength(0); i++){
        for(int j = 0; j < matr.GetLength(1); j++){
            if (i % 2 == 0 && j % 2 == 0){
        Console.Write($"{matr[i,j] * matr[i,j]} ");
            } else Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
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
ElementSquare(matrix);
