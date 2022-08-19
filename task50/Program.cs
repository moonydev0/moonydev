Console.Write("Введите строку - поиск");
int rowsSearch = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  столбец - поиск");
int columnsSearch = Convert.ToInt32(Console.ReadLine());
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
            Console.Write($"{array[rows,columns]} ");
        }
        Console.WriteLine();
    }
    return array;
}

void CheckArray(int [,] array,int rows,int columns){
    if(rowsSearch < 0 | rowsSearch > array.GetLength(0) | columnsSearch < 0 | columnsSearch > array.GetLength(1)){
        Console.WriteLine("такого числа в массиве нет");
    }else{
        Console.Write($"{array[rowsSearch,columnsSearch]}");
    }
}

int [,] array = GetArray(rows,columns);
CheckArray(array,rows,columns);