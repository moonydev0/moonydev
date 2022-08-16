int [] PushRandomIntenger(int length)
{
    int[] array = new int [length];
    Random random = new Random();
    for(int i = 0;i < length;i++){
        array[i] = random.Next(100,999);
    }
    return array;
}
int  CheckAndPrintArray (int [] array)
{
    int count = 0;
    Console.Write('[');
    for(int i = 0;i < array.Length;i++){
        if((array[i] % 2) == 0){
            count++;
        }
        Console.Write(array[i]);
        Console.Write(',');
    }
    Console.Write(']');
    return count;
}

int [] array = PushRandomIntenger(4);
int count = CheckAndPrintArray(array);
Console.Write($"Четных чисел - {count}");