class Fraction
{
    private int _top { get; set; }
    private int _bottom { get; set; }

    public int Top
    {
        get { return _top; }
        set { _top = value; }
    }

    public int Bottom
    {
        get { return _bottom; }
        set { _bottom = value; }
    }


    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public String GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public Double GetDecimalValue()
    {
        return _top * 1.0 / _bottom;
    }

}