//9.2
//1
long a = 264895468854;
Console.WriteLine(a + "=" + Convert.ToString(a, 2));
Console.WriteLine(~a + "=" + Convert.ToString(~a, 2));
long b = 256;
Console.WriteLine(b + "=" + Convert.ToString(b, 2));
Console.WriteLine(~b + "=" + Convert.ToString(~b, 2));
//2
int c = 256;
c >>= 1;
Console.WriteLine(c);
c <<= 1;
Console.WriteLine(c);
//3
int d = 289;
d += 2487;
Console.WriteLine(d);
d *= 2487;
Console.WriteLine(d);
d -= 2487;
Console.WriteLine(d);
d /= 2487;
Console.WriteLine(d);
d %= 2487;
Console.WriteLine(d);
d >>= 2487;
Console.WriteLine(d);
d <<= 2487;
Console.WriteLine(d);

int g = 144;
g += 2487;
Console.WriteLine(g);
g *= 2487;
Console.WriteLine(g);
g -= 2487;
Console.WriteLine(g);
g /= 2487;
Console.WriteLine(g);
g %= 2487;
Console.WriteLine(g);
g >>= 2487;
Console.WriteLine(g);
g <<= 2487;
Console.WriteLine(g);

int e = 36274;
e += 2487;
Console.WriteLine(e);
e *= 2487;
Console.WriteLine(e);
e -= 2487;
Console.WriteLine(e);
e /= 2487;
Console.WriteLine(e);
e %= 2487;
Console.WriteLine(e);
e >>= 2487;
Console.WriteLine(e);
e <<= 2487;
Console.WriteLine(e);

// дз 10.1

//Console.Write("Введите радиус:");
//double R = double.Parse(Console.ReadLine());
//double S = Math.PI * R * R;
//double L = 2 * Math.PI * R;
//Console.WriteLine($"Площадь окружности = {S:F2}");
//Console.WriteLine($"Длинна окружности = {L:F2}");

// дз 10.2

//Console.Write("Введите катет А: ");
//double A = double.Parse(Console.ReadLine());
//Console.Write("Введите гипотенузу C: ");
//double C = double.Parse(Console.ReadLine());
//double B = Math.Sqrt(C * C - A * A);
//Console.WriteLine($"Значение второго катета = {B:F2}");