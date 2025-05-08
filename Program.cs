Console.Write("Input the size of the square matrix (less than 5): ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] m = new int[n, n];
Console.WriteLine($"Input elements in the matrix:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"Element - [{i}], [{j}]: ");
        m[i, j] = Convert.ToInt32(Console.ReadLine());
    
    }
}
PrintMatrix(m);
int sum = 0;
for (int i = 0; i < n; i++)
{
    sum += m[i, n - i - 1];
}
Console.WriteLine($"The sum of the right diagonal is: {sum}");
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}