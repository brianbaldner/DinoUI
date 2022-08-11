namespace DinoUI
{
    public class LoadingScreen
    {
        public LoadingScreen(int progress = 0)
        {
            Console.Clear();
            Console.Write("\n\n\n");


            var title = "Now Loading:".Center();
            Console.WriteLine(title);
            Console.WriteLine("\n");
            Console.WriteLine((progress + "%").Center());
            string rend = new String('█', 52) + '\n' +
            "█" + new String('▒', progress / 2) + new String(' ', 50 - progress / 2) + "█\n" +
            new String('█', 52);
            Console.WriteLine(rend.Center());
        }

        public void SetProgress(int progress)
        {
            Console.CursorTop = Console.CursorTop - 6;
            Console.WriteLine("\n");
            Console.WriteLine((progress + "%").Center());
            string rend = new String('█', 52) + '\n' +
            "█" + new String('▒', progress / 2) + new String(' ', 50 - progress / 2) + "█\n" +
            new String('█', 52);
            Console.WriteLine(rend.Center());
        }
    }
}