Console.Write("Введите числа через пробел");
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int result = 0;

for(int i = 0;i<numbers.Length;i++){
    if(numbers[i] > 0){
        result++;
    }
}

Console.WriteLine(result);