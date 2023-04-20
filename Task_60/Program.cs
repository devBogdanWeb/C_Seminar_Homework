int[,,] arr = new int[2, 2, 2];

// Заполнение массива неповторяющимися двузначными числами
int num = 10;
for (int i = 0; i < 2; i++)
{
  for (int j = 0; j < 2; j++)
  {
    for (int k = 0; k < 2; k++)
    {
      arr[i, j, k] = num;
      num++;
    }
  }
}

// Вывод массива на экран с индексами каждого элемента
for (int i = 0; i < 2; i++)
{
  for (int j = 0; j < 2; j++)
  {
    for (int k = 0; k < 2; k++)
    {
      Console.Write(arr[i, j, k] + "(" + i + "," + j + "," + k + ") ");
    }
    Console.WriteLine();
  }
}