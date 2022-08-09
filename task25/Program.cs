int Multiply(int a,int b)
{
    int result = a;
    for(int i = 1;i < b;i++){
        a*=result;
    }
    return a;
}
int res = Multiply(2,4);
Console.Write(res);