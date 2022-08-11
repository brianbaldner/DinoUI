# DinoUI
![GitHub Workflow Status](https://img.shields.io/github/workflow/status/BrianBaldner/DinoUI/Deploy%20to%20NuGet?style=for-the-badge) ![Nuget](https://img.shields.io/nuget/v/DinoUI?style=for-the-badge) ![Nuget](https://img.shields.io/nuget/dt/DinoUI?style=for-the-badge) ![GitHub](https://img.shields.io/github/license/BrianBaldner/DinoUI?style=for-the-badge)
<p align="center">
<img src="https://raw.githubusercontent.com/brianbaldner/DinoUI/master/testexe.jpg" width="600" />
    </p>

DinoUI is the easiest way to make a UI for your .NET console project.

## Installation

Install to your project with [Nuget](https://www.nuget.org/packages/DinoUI)

## Usage

```csharp
using DinoUI;

var config = new MainConfig()
    {
        Title = "DinoUI",
        Buttons = button,
        ForegroundColor = ConsoleColor.White,
        BackgroundColor = ConsoleColor.DarkRed
    };
//Load Home Screen
HomeScreen.Run(config).Invoke();

//Create progress bar
var lscreen = new LoadingScreen();
lscreen.SetProgress(50)

//Show an alert screen with an OK button
Popup.Alert("The task has completed");

//A confirmation screen where you can select "OK" or "Cancel"
var r = Popup.Confirm("Are you sure you want to see popups?");
    if (r)
        Popup.Alert("You said Ok");
    else
        Popup.Alert("You said Cancel");

//A prompt box to ask for input
string name = TextInput.Run("What is your name?");

```

## Contributing
If you would like to request a new screen, create an issue with the tag "Screen Idea" to suggest the idea. If you find a bug, open an issue or you can also make a pull request.

## License
[MIT](https://choosealicense.com/licenses/mit/)
