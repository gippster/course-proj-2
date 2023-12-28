namespace course_proj_2;

internal class Menu
{
    public Menu(IEnumerable<MenuItem> items)
    {
        _items = items.ToList();
    }

    public void Run(int row, int col)
    {
        var index = 0;
        while (true)
        {
            var itemsCount = _items.Count();
            DrawMenu(row, col, index);
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.DownArrow:
                    index = ++index % itemsCount;
                    break;
                case ConsoleKey.UpArrow:
                    index = (--index + itemsCount) % itemsCount;
                    break;
                case ConsoleKey.Enter:
                    var item = _items.ElementAt(index);
                    item.Action();

                    if (item.Children.Any())
                    {
                        for (var i = 0; i < item.Children.Count(); i++)
                        {
                            _items.Insert(index + i + 1, item.Children.ElementAt(i));
                        }
                        break;
                    }
                    return;
            }
        }
    }

    private List<MenuItem> _items;

    private void DrawMenu(int row, int col, int index)
    {
        Console.SetCursorPosition(col, row);
        Console.WriteLine();

        for (int i = 0; i < _items.Count(); i++)
        {
            if (i == index)
            {
                Console.BackgroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.WriteLine(_items.ElementAt(i).Name);
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
