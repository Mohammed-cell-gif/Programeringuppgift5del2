// See https://aka.ms/new-console-template for more information
double[] temperatur = { 4.5, 3.2, 6.7, 6.1, 2.1, 1.6, 2.9 };
double sum = 0, average;
Console.WriteLine("Initial Array");
foreach (double a in temperatur)
{
    Console.WriteLine(a);
    sum += a;
} 
 average = sum / temperatur.Length;
Console.WriteLine("Average of array is {0:F2}",average);
