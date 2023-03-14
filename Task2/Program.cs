Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int M, int N)
{
    if (M == N) return M;
    return (M + SumNumbers(M + 1, N));
}
Console.WriteLine(SumNumbers(M, N));


