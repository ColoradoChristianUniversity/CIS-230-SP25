using System.Drawing;

public class Program
{
    static Program()
    {
        Console.Clear();
        Console.CursorVisible = false;
    }

    public static readonly string[] Keyboard =
    [
        "   1 2 3 4 5 6 7 8 9 0   ",
        "   Q W E R T Y U I O P   ",
        "   A S D F G H J K L    ",
        "     Z X C V B N M       ",
    ];

    private static readonly int TopOffset = 2;
    private static readonly int LeftOffset = 2;

    public static void Main(string[] args)
    {
        ConsoleKeyInfo keyInfo = default;

        while (true)
        {
            for (int index = 0; index < Keyboard.Length; index++)
            {
                var line = Keyboard[index];
                Draw(line, LeftOffset, TopOffset + index * 2);

                if (keyInfo.KeyChar is char key 
                    && line.Contains(keyInfo.KeyChar, StringComparison.CurrentCultureIgnoreCase))
                {
                    HighlightLetter(index, line, key);
                }
            }

            keyInfo = Console.ReadKey(true);
        }

        static void HighlightLetter(int index, string item, char key)
        {
            var top = index * 2 + TopOffset;
            var left = item.IndexOf(key, StringComparison.CurrentCultureIgnoreCase) + LeftOffset;
            Draw(key.ToString().ToUpper(), left, top, ConsoleColor.Black, ConsoleColor.White);
        }
    }

    public static void Draw(string text, int? x = null, int? y = null, 
        ConsoleColor? foregroundColor = null, ConsoleColor? backgroundColor = null)
    {
        var (left, top) = Console.GetCursorPosition();
        var point = new Point(left, top);

        Console.SetCursorPosition(x ?? left, y ?? top);
        Console.ForegroundColor = foregroundColor ?? Console.ForegroundColor;
        Console.BackgroundColor = backgroundColor ?? Console.BackgroundColor;
        Console.Write(text);

        Console.ResetColor();
        Console.SetCursorPosition(left, top);
    }
}