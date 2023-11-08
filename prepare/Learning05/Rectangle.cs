class Rectangle : Shape
{
    private Double _length;
    private Double _width;

    public Rectangle(Double length, Double width, string color) : base(color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _width * _length;
    }
}