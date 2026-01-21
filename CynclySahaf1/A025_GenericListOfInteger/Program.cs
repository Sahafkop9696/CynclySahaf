// See https://aka.ms/new-console-template for more information
List<int> points = new List<int> { 10, 20, 30, 40 };

foreach(int point in points)
{
    Console.WriteLine("point");
}

Console.WriteLine();
Console.WriteLine("Sum of points:");
int sum = 0;
foreach (int point in points)
{
    sum = sum + point;
}
Console.WriteLine(sum);
