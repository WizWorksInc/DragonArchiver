# Contributing

> Currently, this project is still very early development, and as such, we are somewhat relaxed with how you contribute but consider this document as a guide on how to best contribute.

When contributing to this repository, please first discuss the change you wish to make via issue,
email, or any other method with the owners of this repository before making a change.

Please note we have a code of conduct; please follow it in all your interactions with the project.

## Forking Project

All contributions must start with a fork of the repository. So please fork the project before continuing!

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


## Building Project

1. Fork the `main` branch as a personal repository.
2. Clone your forked repository.
3. Run `RUN_THIS.py` to init submodules.
4. Compile the solution.

## Pull Request Process

1. Ensure any install or build dependencies are removed before the end of the layer when doing a
   build.
2. Update the appropriate documentation with details of changes to the interface; this includes new environment
   variables, exposed ports, useful file locations, and container parameters.
3. Increase the version numbers in any examples files and the README.md to the new version that this
   Pull Request would represent. The versioning scheme we use is [SemVer](http://semver.org/).
4. You may merge the Pull Request once you have the sign-off of one other developers, or if you
   do not have permission to do that, you may request the reviewer to merge it for you.

## Code of Conduct

Please read our [code of conduct](CODE_OF_CONDUCT.md) as we will be holding violators of it responsible.
