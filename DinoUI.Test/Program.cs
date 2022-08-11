using DinoUI;
static void Main()
{
    ButtonInfo[] button = {new ButtonInfo()
{
    Title = "Loading Screen",
    OnPress = LoadingScreen
},
new ButtonInfo()
{
    Title = "Text Input",
    OnPress= Input
},
new ButtonInfo()//ADD TEXT INPUT
{
    Title = "View Popups",
    OnPress = Popups
},
    new ButtonInfo()
{
    Title = "View Github",
    OnPress= Github
}};
    var config = new MainConfig()
    {
        Title = "Dino  UI",
        Buttons = button,
        ForegroundColor = ConsoleColor.White,
        BackgroundColor = ConsoleColor.DarkRed
    };
    HomeScreen.Run(config).Invoke();
}
Main();

static void LoadingScreen()
{
    var lscreen = new LoadingScreen();

    for (int i = 0; i <= 100; i++)
    {
        lscreen.SetProgress(i);
        Thread.Sleep(10);
    }

    Popup.Alert("The task has completed. Go to MultiversusTracker.com and try it out. Also go to brianbaldner.com because that is also fun.");
    Main();
}
static void Popups()
{
    var r = Popup.Confirm("Are you sure you want to see popups?");
    if (r)
        Popup.Alert("You said Ok");
    else
        Popup.Alert("You said Cancel");
    /*System.Diagnostics.Process.Start(new ProcessStartInfo
    {
        FileName = "https://github.com/brianbaldner",
        UseShellExecute = true
    });*/
    Main();
}
static void Input()
{
    string name = TextInput.Run("What is your name?");
    Popup.Alert("Your name is " + name);
    Main();
}
static void Github()
{
    System.Diagnostics.Process.Start(new ProcessStartInfo
    {
        FileName = "https://github.com/brianbaldner",
        UseShellExecute = true
    });
    Main();
}