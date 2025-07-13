namespace Task_2;

public class Player
{
    private int _x;
    private int _y;
    public readonly char PlayerIcon = '@';

    public int X
    {
        get => _x;
        set
        {
            if (value <= Map._mapLimit)
                _x = value;
            else Console.WriteLine($"Map size cannot be more than {Map._mapLimit}");
        }
    }

    public int Y
    {
        get => _y;
        set
        {
            if (value <= Map._mapLimit)
                _y = value;
            else Console.WriteLine($"Map size cannot be more than {Map._mapLimit}");
        }
    }
}