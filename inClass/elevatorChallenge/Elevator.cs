public class Elevator {

    // Attributes
    private int _currentFloor;
    private bool _doorClosed = false;
    private List<int> _floors = new List<int>();

    // Constructor
    public Elevator(int currentFloor, bool doorClosed, int numberOfFloors)
    {
        _currentFloor = currentFloor;
        for (int i = 1; i <= numberOfFloors; i++)
        {
            _floors.Add(i);
        }
    }

    // Methods
    public List<int> GetList()
    {
        return _floors;
    }

    public bool CloseDoor()
    {
        return true;
    }

    public bool OpenDoor()
    {
        return false;
    }

    public void MoveToFloor()
    {

    }

    public void CallElevator()
    {

    }

    public void ListFloorsAvailable()
    {
        for (int i = 0; i < _floors.Count(); i++)
        {
            if (i != _currentFloor)
            {
                Console.WriteLine(i);
            }
        }
    }
}