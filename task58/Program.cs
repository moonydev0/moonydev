Console.Write("Введите количество строк для сoздания 1 массива");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для создания 1 массива");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк для сoздания 2 массива");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для создания 2 массива");
int columns2 = Convert.ToInt32(Console.ReadLine());

int [,] GetArray(int m,int n){

    int [,] array = new int[m, n];

    Random random = new Random();
    for (int rows = 0; rows < m; rows++){
        for (int columns = 0; columns < n; columns++){
            array[rows, columns] = random.Next(1,10); 
        }
    }
    return array;
}
int [,] array1 = GetArray(rows1,columns1);
Print(array1);
int [,] array2 = GetArray(rows2,columns2);
Print(array2);
int [,] result = new int[rows1,columns2];
Multiply(array1,array2,result);
Print(result);

void Multiply(int[,] first, int[,] second, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < first.GetLength(1); k++)
      {
        sum += first[i,k] * second[k,j];
      }
      result[i,j] = sum;
    }
  }
}

void Print (int [,] arr) {
    for (int rows = 0; rows < arr.GetLength(0); rows++){
        for (int columns = 0; columns < arr.GetLength(1); columns++){
            Console.Write($"{arr[rows,columns]} ");
        }
        Console.WriteLine();
    }
}