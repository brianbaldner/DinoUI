namespace DinoUI
{
    public class MainConfig
    {
        public ButtonInfo[] Buttons;
        public string Title;
        public ConsoleColor ForegroundColor = ConsoleColor.White;
        public ConsoleColor BackgroundColor = ConsoleColor.Black;
    }
    public class ButtonInfo
    {
        public Action OnPress;
        public string Title;
    }
}
