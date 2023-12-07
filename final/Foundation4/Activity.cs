public class Activity {

    protected string _date;
    protected double _length;
    protected string _name;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date} {_name} ({_length} min)- Distance {GetDistance()}, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}