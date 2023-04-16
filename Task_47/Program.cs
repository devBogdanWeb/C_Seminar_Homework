int m = 3; // количество строк
int n = 4; // количество столбцов

// Создание двумерного массива
double[,] array = new double[m, n];

// Заполнение массива случайными числами
Random random = new Random();
for (int i = 0; i < m; i++)
{
  for (int j = 0; j < n; j++)
  {
    array[i, j] = random.NextDouble();
  }
}

// Вывод массива на консоль
for (int i = 0; i < m; i++)
{
  for (int j = 0; j < n; j++)
  {
    Console.Write("{0:f2}\t", array[i, j]);
  }
  Console.WriteLine();
}