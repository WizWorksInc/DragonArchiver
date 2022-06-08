# Development Guide (UNDER CONSTRUCTION)

Dragon Archiver is built using .NET Core and closely adheres to the Model-View-ViewModel (MVVM) architecture. MVVM allows us to decouple our application to make extensibility easier in the long run.

If you need any help on the topic, please join our discord and ask questions!

## Guidelines to Follow

- Always adhere to the Model-View-ViewModel (MVVM) architecture
- When creating something new, always look that you are following DRY (Don't Repeat Yourself)
- Remember, KISS, keep it short and simple or the more brash statement of keep it simple stupid!
- Always aim to avoid coupling your code! We should generally be seeking to decouple whenever possible.
- Do what the Boy Scouts do when you are working on code. Leave it better than you found it!
- Documenting your code is essential, but it is detrimental to document. If the code does not make logical sense, it may need documentation!
- We follow the Clean Code Philosophy, and you should too! When naming variables or writing code, what is happening should make logical sense from just a glance. So name your variables robustly and write code that is easy to read!
- Please have meaningful commit names when possible.
- If you ever are lost or confused, don't be afraid to ask for help!

> These guidelines are primarily suggestions, not requirements, but failure to follow the guidelines could lead to your Pull Request getting declined or asked for changes. So generally, it is in your best interest to follow these guidelines to the best of your ability!

## Setting up your development environment 
### Setting up for Visual Studio
1. Make sure you have the most recent version of visual studio installed.

2. Install the [Avalonia extension](https://marketplace.visualstudio.com/items?itemName=AvaloniaTeam.AvaloniaforVisualStudio) for visual studio.

3. Run the command `dotnet new -i Avalonia.Templates` from the command prompt on your machine.

4. Your good to go! Now just follow the build instructions.


### Setting up for JetBrains Rider

1. Download and install .NET 6 SDK [Download .NET (Linux, macOS, and Windows) (microsoft.com)](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

2. Make sure you have the most recent version of JetBrains Rider installed.

3. Run the command `dotnet new -i Avalonia.Templates` from the command prompt on your machine.

4. Install the Avalonia Plugin

   Once Rider loads you will see the Welcome Screen. Click the `Configure` dropdown and select `Plugins`.

![rider-welcome](https://avaloniaui.net/docs/advanced-tutorial/images/rider-welcome.png)

A new Preferenes Screen will open up. Click the `Settings` icon as shown and select `Manage Plugin Repositories...`

![configure-plugin-repos](https://avaloniaui.net/docs/advanced-tutorial/images/configure-plugin-repos.png)

Click the `+` icon and enter the url `https://plugins.jetbrains.com/plugins/dev/14839` then click `OK`:

![enter-plugin-repo](https://avaloniaui.net/docs/advanced-tutorial/images/enter-plugin-repo.png)

Now click on the `Marketplace` tab and search for `Avalonia`. Select `AvaloniaRider` and click `Install`; once thats done, click the `Restart IDE` button that appears.

![plugin-install](https://avaloniaui.net/docs/advanced-tutorial/images/plugin-install.png)

Now Rider should be ready to develop for DragonArchiver! Now just follow the build instructions.


## Building

1. Fork the `main` branch as a personal repository.
2. Clone your forked repository.
3. Run `RUN_THIS.py` to init submodules.
4. Compile the solution.

## How does MVVM Work?

WIP
