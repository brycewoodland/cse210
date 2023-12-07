public class Swim: Activity {

    private int _numOfLaps;

    public Swim(string date, int length, int numOfLaps) : base(date, length)
    {
        _name = "Swimming";
        _numOfLaps = numOfLaps;
    }

    public override double GetDistance()
    {
        return (_numOfLaps * 50) / (1000 * 0.62);
    }

    public override double GetSpeed()
    {
        return GetDistance() / _length * 60;
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }
}