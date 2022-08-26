Console.Write("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int sum = 0;

void Recurcive (int n,int m) {
    if (n > m) {
        Console.WriteLine(sum);
        return;
    }
    sum+=n;
    Recurcive(n + 1,m);
}
Recurcive(n,m);