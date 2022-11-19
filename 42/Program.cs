Console.WriteLine("Введите k1");
float k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1");
float b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k2");
float k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
float b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2 && b1 == b2) Console.WriteLine("Графики лежат на 1 линии");
else if (k1 == k2) Console.WriteLine("Графики параллельны");
else
{
    float x = (b2 - b1) / (k1 - k2);
    float y = k1 * x + b1;
    Console.WriteLine($"X:{x} Y:{y}");
}