using Figgle;

namespace DinoUI
{
    public partial class HomeScreen
    {
        public static Action Run(MainConfig config)
        {
            Console.ForegroundColor = config.ForegroundColor;
            Console.BackgroundColor = config.BackgroundColor;
            Console.Clear();
            Console.CursorVisible = false;
            Console.Title = config.Title;

            Console.SetWindowSize(150, 40);
            Console.Write("\n\n\n");
            var title = FiggleFonts.Basic.Render(config.Title);

            title = title.Center();


            Console.WriteLine(title);

            int buttonwidth = 25;

            string buttontitle = "Test Button";
            var isOdd = buttontitle.Length % 2 == 0;


            string boxestext = Utils.RenderButtons(config.Buttons, 25);
            int boxeswidth = boxestext.Length;
            int navwidth = boxeswidth - buttonwidth;

            Console.WriteLine(boxestext.Center());
            Console.WriteLine();

            int arrowloc = 0;
            string nc = new String(' ', arrowloc * 28) + "^" + new String(' ', (config.Buttons.Length - arrowloc - 1) * 28);
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
                    return config.Buttons[arrowloc].OnPress;
                }
                else
                {
                    continue;
                }
                if (arrowloc < 0)
                {
                    arrowloc = config.Buttons.Length - 1;
                }
                if (arrowloc > config.Buttons.Length - 1)
                {
                    arrowloc = 0;
                }
                string n = new String(' ', arrowloc * 28) + "^" + new String(' ', (config.Buttons.Length - arrowloc - 1) * 28);
                Console.Write("\r{0}", n.Center());
            }
        }
    }
}