int[] array = new int[10]; // создаем массив из 10 элементов

Random random = new Random(); // создаем объект генератора случайных чисел

// заполняем массив случайными числами
for (int i = 0; i < array.Length; i++)
{
  array[i] = random.Next(100); // генерируем случайное число от 0 до 99
}

// выводим массив на экран
Console.WriteLine("Массив:");
foreach (int element in array)
{
  Console.Write(element + " ");
}
Console.WriteLine();

int sum = 0;
// находим сумму элементов, стоящих на нечетных позициях
for (int i = 1; i < array.Length; i += 2)
{
  sum += array[i];
}

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");