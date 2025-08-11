namespace Task_2;

public class Render
{
    private readonly Map _map;
    private readonly Player _player;
    private const char PlayerIcon = '@';
    private const char MapIcon = '.';

    public Render(Map map, Player player)
    {
        _map = map;
        _player = player;
    }

    public void ShowMap()
    {
        for (int i = 0; i < _map.YLimit; i++)
        {
            for (int j = 0; j < _map.XLimit; j++)
                if (j == _player.X && i == _player.Y)
                    Console.Write(PlayerIcon);
                else Console.Write(MapIcon);

            Console.WriteLine();
        }
    }
}