// y = k1 * x + b1
// y = k2 * x + b2

Console.Write("Введите k1: ");
 int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
 int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
 int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
 int b2 = Convert.ToInt32(Console.ReadLine());

int x = (k1-k2)/(b2-b1);
int y = k1 *x + b1;

Console.WriteLine($"x ={x}, y ={y}");