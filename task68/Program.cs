Console.Write("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int A(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return A(m - 1, 1);
  else return A(m - 1, A(m, n - 1));
}


int x = A(m,n);
Console.WriteLine($"Результат = {x}");