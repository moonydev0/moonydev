Console.Write("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int [,]  GetArray(int m,int n){

    int [,] array = new int[m, n];

    Random random = new Random();
    for (int rows = 0; rows < m; rows++){
        for (int columns = 0; columns < n; columns++){
            array[rows, columns] = random.Next(1,10); 
            Console.Write($"{array[rows,columns]}");
        }
        Console.WriteLine();
    }
    return array;
}

int [,] array = GetArray(rows,columns);

void Sum(int [,] arr){
    for (int j = 0; j < arr.GetLength(1); j++)
        {
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.WriteLine($"{ sum / arr.GetLength(0)} ");
    }   
}

Sum(array);