Console.Write("Введите строку");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  столбец");
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

void CheckArray(int [,] array,int rows,int columns){
    if(rows < 0 | rows > array.GetLength(0) | columns < 0 | columns > array.GetLength(1)){
        Console.WriteLine("такого числа в массиве нет");
    }else{
        Console.Write($"{array[rows,columns]}");
    }
}

int [,] array = GetArray(3,4);
CheckArray(array,rows,columns);