public class Run: Activity {

    private double _distance;

    public Run(string date, int length, double distance) : base(date, length)
    {
        _name = "Running";
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _length * 60;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }
}