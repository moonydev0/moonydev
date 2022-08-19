Console.Write("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

void  GetArray(int m,int n){

    double [,] array = new double[m, n];

    Random random = new Random();
    for (int rows = 0; rows < m; rows++){
        for (int columns = 0; columns < n; columns++){
            array[rows, columns] =random.NextDouble() * 100; 
            Console.Write($"{array[rows,columns]} ");
        }
        Console.WriteLine();
    }
    
}

GetArray(rows,columns);