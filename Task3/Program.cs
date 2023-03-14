Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

int Akkerman(int N, int M)
{
    if (N == 0) return M + 1;
    else if (N != 0 && M == 0) return (Akkerman(N - 1, 1));
    else return (Akkerman(N - 1, Akkerman(N, M - 1)));
}
Console.WriteLine(Akkerman(N, M));


