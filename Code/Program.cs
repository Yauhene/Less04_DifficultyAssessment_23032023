// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
double s = 0;
for (int n = 0; n < 15; n++)
{
    int count = 0;
    int i = n;
    while (i > 0)
    {
        count++;
        s += i;
        i = i / 2;
    }
    Console.WriteLine($"n: {n}  count: {count}");
}