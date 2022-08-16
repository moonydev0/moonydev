int [] PushRandomIntenger(int length,int min,int max)
{
    int[] array = new int [length];
    Random random = new Random();
    for(int i = 0;i < length;i++){
        array[i] = random.Next(min,max);
    }
    return array;
}
int  SumAndPrintArray (int [] array)
{
    int sum = 0;
    Console.Write('[');
    for(int i = 0;i < array.Length;i++){
        if (i % 2 != 0 ){
            sum+=array[i];
        }
        Console.Write(array[i]);
        Console.Write(',');
    }
    Console.Write(']');
    return sum;
}
int [] array = PushRandomIntenger(5,1,10);
int count = SumAndPrintArray(array);
Console.Write($"Cуммa элементов, стоящих на нечётных позициях - {count}");