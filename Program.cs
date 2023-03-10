using System.Diagnostics;
using CSharpConsoleShape.Models;
using CSharpConsoleShape.Models.Forms;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(AreaCalculator);
    }
}
public class AreaCalculator
{
    public double TotalArea(Shape[] arrShapes)
    {
        double area = 0;
        foreach (var objShape in arrShapes)
        {
            area += objShape.Area();
        }
        return area;
    }
}

