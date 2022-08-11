namespace DinoUI
{
    public class TextInput
    {
        public static string Run(string prompt, string input = "")
        {
            Console.Clear();

            Console.Write("\n\n\n");


            var title = prompt.Center();
            Console.WriteLine(title);
            string i = input;
            Console.WriteLine("\n");
            string rend = "█" + new String('▀', 100) + "█\n" +
        "█" + i + "▄" + new String(' ', 99 - i.Length) + "█\n" +
        "█" + new String('▄', 100) + "█";
            Console.WriteLine(rend.Center());
            Console.CursorTop = Console.CursorTop - 3;
            char[] whitelist = " ~!@#$%^&*()_-+=~`{[}]|\\:;<,>.?/".ToCharArray();
            while (true)
            {
                var y = Console.ReadKey(true);
                if (y.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (y.Key == ConsoleKey.Backspace)
                {
                    if (i.Length > 0)
                        i = i.Remove(i.Length - 1, 1);
                }
                else
                {
                    if (i.Length < 100 && Char.IsLetterOrDigit(y.KeyChar) || whitelist.Contains(y.KeyChar))
                        i += y.KeyChar;
                }
                rend = "█" + new String('▀', 100) + "█\n" +
        "█" + i + "▄" + new String(' ', 99 - i.Length) + "█\n" +
        "█" + new String('▄', 100) + "█";
                Console.WriteLine(rend.Center());
                Console.CursorTop = Console.CursorTop - 3;
            }
            return i;
        }
    }
}
