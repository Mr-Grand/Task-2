namespace Task_2;

public class Map
{
    /*public const int _mapLimit = 10;*/
    private int _xLimit;
    private int _yLimit;
    
    public int XLimit
    {
        get => _xLimit;
        set
        {
            if (value > 0)
                _xLimit = value;
            else
                Console.WriteLine("Map should be more than 0");
        }
    }

    public int YLimit
    {
        get => _yLimit;
        set
        {
            if (value > 0)
                _yLimit = value;
            else
                Console.WriteLine("Map should be more than 0");
        }
    }
    
    public Map(int xLimit, int yLimit)
    {
        XLimit = xLimit;
        YLimit = yLimit;
    }
}