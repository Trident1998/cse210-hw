using System.Drawing;

abstract class Shape
{
    private String _color;

    public String Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public Shape(String color)
    {
        _color = color;
    }

    public abstract Double GetArea();
}
