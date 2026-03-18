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

var Sam = new Person("Sam", 21);
Console.WriteLine(Sam.ToString());
var Dean = new Person("Dean", 27);
Sam.greet(Dean);