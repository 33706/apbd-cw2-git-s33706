var x = 5;
for (var i = 0; i < x; i++)
{
    Console.WriteLine("Hi, "+i);
}

static void scalarCalc(int[] x, int[] y)
{
    double scalar = 0;
    foreach (var dim in x)
    {
        scalar += Math.Sqrt(dim^2 - dim^2);
    }
}

Console.WriteLine("Hello, World!");