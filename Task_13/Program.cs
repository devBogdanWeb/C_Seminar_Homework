Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
if (input.Length >= 3)
{
  Console.WriteLine($"Третья цифра числа: {input[2]}");
}
else
{
  Console.WriteLine("В числе меньше трех цифр.");
}