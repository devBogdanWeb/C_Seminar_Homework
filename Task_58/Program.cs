// Задаем размерность матриц
int rows1 = 2, cols1 = 2;
int rows2 = 2, cols2 = 2;

// Задаем значения матриц
int[,] matrix1 = { { 2, 4 }, { 3, 2 } };
int[,] matrix2 = { { 3, 4 }, { 3, 3 } };

// Проверяем, можно ли перемножить матрицы
if (cols1 != rows2)
{
  Console.WriteLine("Умножение невозможно!");
  return;
}

// Создаем новую матрицу для результатов умножения
int[,] result = new int[rows1, cols2];

// Выполняем умножение матриц
for (int i = 0; i < rows1; i++)
{
  for (int j = 0; j < cols2; j++)
  {
    for (int k = 0; k < cols1; k++)
    {
      result[i, j] += matrix1[i, k] * matrix2[k, j];
    }
  }
}

// Выводим результат
Console.WriteLine("Результирующая матрица:");
for (int i = 0; i < rows1; i++)
{
  for (int j = 0; j < cols2; j++)
  {
    Console.Write("{0} ", result[i, j]);
  }
  Console.WriteLine();
}