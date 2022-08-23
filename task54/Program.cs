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

int [,] SortArr (int [,] array) {

    for (int i = 0; i < array.GetLength(0);i++) {
        
        for(int k = 0; k < array.GetLength(1); k++) {
            
            for(int j = k; j < array.GetLength(1); j++) {
                
                if (array[i,k] < array[i,j]) 
                    {
                        int temp = array[i,k];
                        array[i,k] = array[i,j];
                        array[i,j] = temp;
                    }
            }
        }
    }
    return array;
}
int [,] sortedArr = SortArr(array);

void ShowArray(int [,] arr){
    for (int rows = 0; rows < arr.GetLength(0); rows++){
        for (int columns = 0; columns < arr.GetLength(1); columns++){
            Console.Write($"{arr[rows,columns]} ");
        }
        Console.WriteLine();
    }
}

ShowArray(sortedArr);