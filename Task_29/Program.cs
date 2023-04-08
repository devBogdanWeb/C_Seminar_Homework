char[] arr = new char[8]; // создание массива из 8 символов

for (int i = 0; i < arr.Length; i++)
{
  Console.Write($"Введите символ #{i + 1}: ");
  arr[i] = Console.ReadKey().KeyChar; // чтение символа с консоли
  Console.WriteLine(); // переход на новую строку
}

Console.WriteLine("Вы ввели следующие символы:");
foreach (char num in arr)
{
  Console.Write($"{num} "); // вывод символов на консоль
}