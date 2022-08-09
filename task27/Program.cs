// n = int(input("Введите число:"))
// tot = 0
// while(n > 0):
//     dig = n % 10
//     tot = tot + dig
//     n = n//10
// print("Сумма цифр равна:", tot
int Sum(int a)
{
    int res = 0;
    while(a > 0) {
        int b = a % 10;
        res = res + b;
        a = a/10;
    }
    return res;
}
int result = Sum(213);
Console.Write(result);