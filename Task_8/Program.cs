Console.WriteLine("Введите число:");
// считываем число N
int n = int.Parse(Console.ReadLine());

// начинаем с 2, т.к. 1 не является четным числом
for (int i = 2; i <= n; i += 2)
{
  Console.Write(i + " ");
}
