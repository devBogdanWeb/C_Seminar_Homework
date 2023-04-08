Console.WriteLine("Введите число A:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите натуральную степень B:");
int b = int.Parse(Console.ReadLine());

int result = 1;
for (int i = 0; i < b; i++)
{
  result *= a;
}

Console.WriteLine("{0} в степени {1} равно {2}", a, b, result);