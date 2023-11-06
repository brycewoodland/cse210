using System.Drawing;
using System.Formats.Asn1;

public class Shape {
    private string _color;

    public Shape(string color) {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor()
    {

    }

    public virtual double GetArea()
    {
        return 0;
    }
}