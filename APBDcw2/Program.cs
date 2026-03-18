using APBDcw2;

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

static void calculateMin(int[] arr)
{
    var min = 0;
    foreach (var x in arr)
        {
        if (x < min)
            {
                min = x;
                Console.WriteLine("new minimum found");
            }
        }
}

var Sam = new Person("Sam", 21);
Console.WriteLine(Sam.ToString());
var Dean = new Person("Dean", 27);
Sam.greet(Dean);
Dean.greet(Sam);