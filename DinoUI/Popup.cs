namespace DinoUI
{
    public class Popup
    {
        public static void Alert(string text, bool wait = true)
        {
            Console.Clear();
            Console.Write("\n\n\n\n");
            string rend = new String('█', 75) + '\n' +
            "█" + new String(' ', 73) + "█\n";

            string[] ptext = text.SplitWithWord(69);
            for (int i = 0; i < ptext.Length; i++)
            {
                ptext[i] = "█" + ptext[i].Center(73) + "█\n";
            }

            rend += string.Join("", ptext) + "█" + new String(' ', 73) + "█\n" + new String('█', 75);

            Console.WriteLine(rend.Center());

            if (wait)
            {
                Console.WriteLine();
                Console.WriteLine(Utils.RenderMinimalButtons(new string[] { "Close" }).Center() + "\n" + "^".Center());
                while (true)
                {
                    var k = Console.ReadKey();
                    if (k.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
        }
        public static bool Confirm(string text, string button1 = "Cancel", string button2 = "Ok")
        {
            Console.Clear();
            Console.Write("\n\n\n\n");
            string rend = new String('█', 75) + '\n' +
            "█" + new String(' ', 73) + "█\n";

            string[] ptext = text.SplitWithWord(69);
            for (int i = 0; i < ptext.Length; i++)
            {
                ptext[i] = "█" + ptext[i].Center(73) + "█\n";
            }

            rend += string.Join("", ptext) + "█" + new String(' ', 73) + "█\n" + new String('█', 75);

            Console.WriteLine(rend.Center());

            Console.WriteLine();
            Console.WriteLine(Utils.RenderMinimalButtons(new string[] { button1, button2  }, 14).Center());

            int arrowloc = 1;
            string nc = new String(' ', arrowloc * 18) + "^" + new String(' ', (1 - arrowloc) * 18);

            Console.Write("\r{0}", nc.Center());
            while (true)
            {
                var s = Console.ReadKey(true);
                if (s.Key == ConsoleKey.LeftArrow)
                {
                    arrowloc--;
                }
                else if (s.Key == ConsoleKey.RightArrow)
                {
                    arrowloc++;
                }
                else if (s.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    return Convert.ToBoolean(arrowloc);
                }
                else
                {
                    continue;
                }
                if (arrowloc < 0)
                {
                    arrowloc = 1;
                }
                if (arrowloc > 1)
                {
                    arrowloc = 0;
                }
                string n = new String(' ', arrowloc * 18) + "^" + new String(' ', (1 - arrowloc) * 18);
                Console.Write("\r{0}", n.Center());
            }

        }
    }
}
