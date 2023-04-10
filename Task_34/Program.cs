int[] array = new int[10]; // создаем массив из 10 элементов
Random random = new Random(); // создаем генератор случайных чисел
int count = 0; // счетчик четных чисел

// заполняем массив случайными положительными трехзначными числами
for (int i = 0; i < array.Length; i++)
{
  array[i] = random.Next(100, 1000);
}

// находим количество четных чисел в массиве
foreach (int num in array)
{
  if (num % 2 == 0)
  {
    count++;
  }
}

// выводим результат
Console.WriteLine($"Количество четных чисел в массиве: {count}");