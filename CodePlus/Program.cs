// See https://aka.ms/new-console-template for more information


int n = Random.Shared.Next(100000);
double s = 0;
for (int j = 2; j < n / 2; j++)
{
    int count = 0;
    int i = n;
    while (i > 0)
    {
        count++;
        //s += i;
        i = i / 2;
    }
    Console.WriteLine($"Для числа n: {n}  количество операций count: {count}");
}