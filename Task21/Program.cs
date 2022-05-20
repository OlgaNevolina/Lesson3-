Console.WriteLine("Введите координаты первой точки ");
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки ");
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double z2 = double.Parse(Console.ReadLine());

double sum = (x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2) + (z1 - z2)*(z1 - z2);
double result = Math.Sqrt(sum);
double n = Math.Round(result, 2);

Console.WriteLine($"Раcстояние между точками {n}");
