namespace Task_2;

internal class Program
{
    private static void Main(string[] args)
    {
        // Создаем карту
        Map map = new(10, 10);
        Player player = new();
        Render render = new(map, player);
        while (true)
        {
            Console.WriteLine($"Здравствуйте!" +
                              $"\nКарта размером {map.XLimit}x{map.YLimit}" +
                              $"\nВведите желаемые координаты игрока:");
            Console.WriteLine("Для Х - ");
            int NewX = int.Parse(Console.ReadLine());
            if (NewX <= 0 || NewX > map.XLimit)
            {
                Console.WriteLine("Вы вышли за пределы!");
                player.X = -1;
                break;
            }
            else
            {
                player.X = NewX - 1; // -1 для корректной отрисовки в массиве карты
            }

            Console.WriteLine("Для Y - ");
            int NewY = int.Parse(Console.ReadLine());
            if (NewY <= 0 || NewY > map.YLimit)
            {
                Console.WriteLine("Вы вышли за пределы!");
                player.Y = -1;
                break;
            }
            else
            {
                player.Y = NewY - 1; 
            }

            // Выводим на экран карту
            if (player.X < 0 || player.Y < 0)
            {
                Console.WriteLine("Вы вне карты!");
            }
            else
            {
                Console.WriteLine("Спасибо! Вот ваше местоположение:");
                render.ShowMap();
            }

            // Чистим окно вывода
            Console.ReadLine();
            Console.Write("\f\u001bc\x1B[3J");  
        }
    }
}