decimal [] PushRandomDouble(int length,int min,int max)
{
    decimal [] array = new decimal [length];
    Random random = new Random();
    for(int i = 0;i < length;i++){
        decimal temp = Convert.ToDecimal(random.NextDouble() * (10 - 1) + 1);
        array[i] = Math.Round(temp,1);
        Console.Write(array[i]+" ");
    }
    return array;
}
decimal FindDiffrence(decimal [] array)
{
    decimal max = array.Max();
    decimal min = array.Min();
    decimal diffrence = max - min;
    return diffrence;
}

decimal[] array = PushRandomDouble(3 ,1,10);
decimal diffrence = FindDiffrence(array);
Console.Write($" Pазница между максимальным и минимальным элементом массива - {diffrence}");

