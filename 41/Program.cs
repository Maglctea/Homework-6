Console.WriteLine("Введите количество чисел");
int countInt = Convert.ToInt32(Console.ReadLine());

int n;
int sum = 0;
Console.WriteLine("Введите числа");
for (int i = 0; i < countInt; i++)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > 0) sum++;
}

Console.WriteLine("Количество положительных чисел");
Console.WriteLine(sum);