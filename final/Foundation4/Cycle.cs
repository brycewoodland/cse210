public class Cycle: Activity {

    private double _speed;

    public Cycle(string date, int length, double speed) : base(date, length)
    {   
        _name = "Cycling";
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return _speed * _length / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}