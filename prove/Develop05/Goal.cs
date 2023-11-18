using System.Dynamic;

abstract class Goal
{
    private int _points;
    private String _name;
    private String _description;
    private int _increaseAmount;

    public String Name
    {
        get { return _name; }
        set {_name = value; }
    }

    public String Description
    {
        get { return _description; }
        set {_description = value; }
    }

    public int IncreaseAmount
    {
        get { return _increaseAmount; }
        set {_increaseAmount = value; }
    }

        public int Points
    {
        get { return _points; }
        set {_points = value; }
    }

    public Goal(String name, String description, int increaseAmount)
    {
        _name = name;
        _description = description;
        _increaseAmount = increaseAmount;
    }

    public Goal(){}

    public abstract Goal GetInstance();

    public abstract String DisplaySummary();

    public abstract String GetStringRepresentation();

    public abstract void GainePoints();
}
