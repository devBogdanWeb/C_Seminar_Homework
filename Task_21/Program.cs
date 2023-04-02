// ввод координат первой точки
Console.Write("Введите координаты первой точки через запятую: ");
string[] coords1 = Console.ReadLine().Split(',');
double x1 = double.Parse(coords1[0]);
double y1 = double.Parse(coords1[1]);
double z1 = double.Parse(coords1[2]);

// ввод координат второй точки
Console.Write("Введите координаты второй точки через запятую: ");
string[] coords2 = Console.ReadLine().Split(',');
double x2 = double.Parse(coords2[0]);
double y2 = double.Parse(coords2[1]);
double z2 = double.Parse(coords2[2]);

// вычисление расстояния между точками
double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

// вывод результата
Console.WriteLine("Расстояние между точками: " + distance.ToString("F2"));