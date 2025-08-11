namespace Task_2;

public class Player
{
    private int _x;
    private int _y;
    private readonly Map _map;

    public int X
    {
        get => _x;
        set
        {
            if (value > 0 && value <= _map.XLimit)
                _x = value;
            else 
                Console.WriteLine($"You should be in 0 - {_map.XLimit} diapason");
        }
    }

    public int Y
    {
        get => _y;
        set
        {
            if (value > 0 && value <= _map.YLimit)
                _y = value;
            else 
                Console.WriteLine($"You should be in 0 - {_map.XLimit} diapason");
        }
    }

    public Player(Map map)
    {
        _map = map;
    }
}