Console.Write("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

void Recurcive (int n) {
    Console.Write($"{n} ");
    if(n != 1) Recurcive(n - 1);
    return;
}
Recurcive(n);