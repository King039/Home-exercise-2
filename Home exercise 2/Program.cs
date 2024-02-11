


// дз 10.1

Console.Write("Введите радиус:");
double R = double.Parse(Console.ReadLine());
double S = Math.PI * R * R;
double L = 2 * Math.PI * R;
Console.WriteLine($"Площадь окружности = {S:F2}");
Console.WriteLine($"Длинна окружности = {L:F2}");

// дз 10.2

//Console.Write("Введите катет А: ");
//double A = double.Parse(Console.ReadLine());
//Console.Write("Введите гипотенузу C: ");
//double C = double.Parse(Console.ReadLine());
//double B = Math.Sqrt(C * C - A * A);
//Console.WriteLine($"Значение второго катета = {B:F2}");