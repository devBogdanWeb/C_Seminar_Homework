Console.Write("Введите номер дня недели: ");
int dayOfWeek = int.Parse(Console.ReadLine());

if (dayOfWeek >= 1 && dayOfWeek <= 5)
{
  Console.WriteLine("Это рабочий день.");
}
else if (dayOfWeek == 6 || dayOfWeek == 7)
{
  Console.WriteLine("Это выходной день.");
}
else
{
  Console.WriteLine("Введите число от 1 до 7");
}
