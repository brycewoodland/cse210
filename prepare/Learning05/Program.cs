using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square sq = new Square("red", 5);
        shapes.Add(sq);

        Rectangle r = new Rectangle("blue", 4, 3);
        shapes.Add(r);

        Circle c = new Circle("orange", 2);
        shapes.Add(c);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}