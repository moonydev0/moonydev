int [] PushRandomIntenger()
{
    int[] array = new int [10];
    Random random = new Random();
    for(int i = 0;i < array.Length;i++){
        array[i] = random.Next(0,10);
    }
    return array;
}
void Print(int [] array)
{
    Console.Write('[');
    for(int i = 0;i < array.Length;i++){
        Console.Write(array[i]);
        Console.Write(',');
    }
    Console.Write(']');
}

int [] array = PushRandomIntenger();
Print(array);