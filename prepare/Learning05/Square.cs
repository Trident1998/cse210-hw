class Square : Shape
{
    private Double _side;

    public Square(Double side, string color) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}
