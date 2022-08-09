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