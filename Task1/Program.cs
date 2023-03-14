Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int end, int start)
 {
     
    if (start == end) return start.ToString();
    return (end + ", " + PrintNumbers(end-1, start));
 }

 Console.WriteLine(PrintNumbers(N, 1));