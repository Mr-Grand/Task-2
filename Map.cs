namespace Task_2;

public class Map
{
    public const int _mapLimit = 10;
    private int _xLimit;
    private int _yLimit;
    public readonly char MapIcon = '.';

    public Map(int XLimit, int YLimit)
    {
        _xLimit = XLimit;
        _yLimit = YLimit;
    }

    public int XLimit
    {
        get => _xLimit;
        set
        {
            if (value <= _mapLimit)
                _xLimit = value;
            else
                Console.WriteLine($"Map size cannot be more than {_mapLimit}");
        }
    }

    public int YLimit
    {
        get => _yLimit;
        set
        {
            if (value <= _mapLimit)
                _yLimit = value;
            else
                Console.WriteLine($"Map size cannot be more than {_mapLimit}");
        }
    }
}