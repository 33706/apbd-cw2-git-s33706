using APBDcw2;

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

static void calculateAverage(int[] arr)
{
    var sum = 0;
    foreach (var x in arr)
    {
        sum += x;
    }
    sum /= arr.Length;
    Console.WriteLine($"Average: {sum}");
}

static void calculateMax(int[] arr)
{
    var max = 0;
    foreach (var x in arr)
        {
        if (x > max)
            {
            max = x;
            }
        }
}

var Sam = new Person("Sam", 21);
Console.WriteLine(Sam.ToString());
var Dean = new Person("Dean", 27);
Sam.greet(Dean);