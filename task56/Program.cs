Console.Write("Введите количество строк для сoздания массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для создания массива");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] GetArray(int m,int n){

    int [,] array = new int[m, n];

    Random random = new Random();
    for (int rows = 0; rows < m; rows++){
        for (int columns = 0; columns < n; columns++){
            array[rows, columns] = random.Next(1,10); 
            Console.Write($"{array[rows,columns]} ");
        }
        Console.WriteLine();
    }
    return array;
}
int [,] array = GetArray(rows,columns);

int CallSum (int [,] array) {
    int min = 0;
    int sum = SumLine(min,array);
    for(int i = 0; i < array.GetLength(1);i++) {
        int res = SumLine(i,array);
        if (sum > res) {
            min = i;
        }
    }
    return min;
}
int min = CallSum(array);
Console.Write($"номер строки с наименьшей суммой элементов: {min} строка");

int SumLine (int i, int [,] array) {
    int sum = 0;
    for (int k = 0; k < array.GetLength(1); k++) {
        sum+=array[i,k];
    }
    return sum;
}
