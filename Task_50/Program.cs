int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int row, col;

Console.WriteLine("Введите позицию элемента в двумерном массиве: ");
Console.Write("Строка: ");
row = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбец: ");
col = Convert.ToInt32(Console.ReadLine());

if (row >= arr.GetLength(0) || col >= arr.GetLength(1))
{
  Console.WriteLine("Элемента с такими координатами не существует. ");
}
else
{
  Console.WriteLine("Значение элемента: " + arr[row, col]);
}