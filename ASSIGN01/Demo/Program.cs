using System.Net.Http.Json;

while (true)
{
    RandomizeColors();

    var options = await LoadOptionsAsync();
    var option = Menu.Show(out var selection, options);

    ReportResults(option, selection);

    Console.ReadKey();
    Console.Clear();
}

static async Task<string[]> LoadOptionsAsync()
{
    Console.WriteLine("Loading data...");
    var options = await new HttpClient()
        .GetFromJsonAsync<string[]>("https://cis-230-sp25.azurewebsites.net/api/StringArray")
        ?? throw new Exception("Failed to get options");
    Console.SetCursorPosition(0, Console.GetCursorPosition().Top - 1);
    return options;
}

static void RandomizeColors()
{
    var colors = new[] { ConsoleColor.DarkRed, ConsoleColor.DarkGreen, ConsoleColor.DarkCyan, ConsoleColor.DarkYellow };
    Menu.HeaderForeground = colors[Random.Shared.Next(colors.Length)];
    Menu.OptionForeground = colors[Random.Shared.Next(colors.Length)];
}

static void ReportResults(string option, int selection)
{
    $"\nYou selected ".Write();
    option.Write(foreground: ConsoleColor.Cyan);
    $", which is number ".Write();
    selection.ToString().Write(foreground: ConsoleColor.Cyan);
    $"\nHit any key to continue...".Write(foreground: ConsoleColor.DarkGray);
}

public static class Menu
{
    static Menu()
    {
        Console.CursorVisible = false;
    }

    public static ConsoleColor HeaderBackground { get; set; } = ConsoleColor.Black;
    public static ConsoleColor HeaderForeground { get; set; } = ConsoleColor.Green;
    public static ConsoleColor OptionBackground { get; set; } = ConsoleColor.Black;
    public static ConsoleColor OptionForeground { get; set; } = ConsoleColor.White;
    public static ConsoleColor HighlightBackground { get; set; } = ConsoleColor.White;
    public static ConsoleColor HighlightForeground { get; set; } = ConsoleColor.Black;

    public static string Show(out int selection, params string[] options)
    {
        var originalTop = Console.GetCursorPosition().Top;
        selection = 1;

        try
        {
            while (true)
            {
                Draw(options, selection);

                var consoleKeys = options
                    .Select((_, i) => ConsoleKey.D0 + (i + 1) % 10)
                    .Concat([ConsoleKey.Escape, ConsoleKey.UpArrow, ConsoleKey.DownArrow, ConsoleKey.Enter])
                    .ToArray();

                WaitFor(out var input, consoleKeys);

                if (input == ConsoleKey.Escape) { return input.ToString(); }
                else if (input == ConsoleKey.Enter) { return options[selection - 1]; }
                else if (input == ConsoleKey.UpArrow) { selection = Math.Max(1, selection - 1); }
                else if (input == ConsoleKey.DownArrow) { selection = Math.Min(options.Length, selection + 1); }
                else
                {
                    var optionIndex = (int)input - (int)ConsoleKey.D1;
                    Draw(options, optionIndex + 1);
                    return options[optionIndex];
                }
            }
        }
        finally
        {
            Console.SetCursorPosition(0, originalTop + options.Length + 2);
        }
    }

    private static void Draw(string[] options, int highlight)
    {
        var originalTop = Console.GetCursorPosition().Top;

        "Select an option:\n".WriteLine(x: 0, foreground: HeaderForeground, background: HeaderBackground);

        for (var i = 0; i < options.Length; i++)
        {
            var foreground = (highlight == i + 1) ? HighlightForeground : OptionForeground;
            var background = (highlight == i + 1) ? HighlightBackground : OptionBackground;
            // add padding
            $" {i + 1:00}. {options[i]} ".WriteLine(x: 2, foreground: foreground, background: background);
        }

        Console.SetCursorPosition(0, originalTop);
    }

    /// <summary>
    /// Waits for the user to press one of the specified allowed keys.
    /// </summary>
    /// <param name="key">The key that was pressed by the user.</param>
    /// <param name="allowed">An array of allowed keys that the user can press.</param>
    private static void WaitFor(out ConsoleKey key, params ConsoleKey[] allowed)
    {
        while (Console.KeyAvailable)
        {
            Console.ReadKey(intercept: true);
        }
        while (!allowed.Contains(key = Console.ReadKey(true).Key)) { }
    }
}

public static class Extensions
{
    public static void WriteLine(this string text, int? x = null, int? y = null, ConsoleColor? foreground = null, ConsoleColor? background = null)
    {
        Write(text + '\n', x, y, foreground, background);
    }

    public static void Write(this string text, int? x = null, int? y = null, ConsoleColor? foreground = null, ConsoleColor? background = null)
    {
        Console.ForegroundColor = foreground ?? Console.ForegroundColor;
        Console.BackgroundColor = background ?? Console.BackgroundColor;

        var (left, top) = Console.GetCursorPosition();

        Console.SetCursorPosition(x ?? left, y ?? top);
        Console.Write(text);

        Console.ResetColor();
    }
}