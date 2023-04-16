int[,] arr = new int[,]
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

int rows = arr.GetLength(0);
int cols = arr.GetLength(1);

for (int j = 0; j < cols; j++)
{
  int sum = 0;
  for (int i = 0; i < rows; i++)
  {
    sum += arr[i, j];
  }
  double average = (double)sum / rows;
  Console.WriteLine($"Среднее арифметическое элементов в столбце {j}: {average}");
}