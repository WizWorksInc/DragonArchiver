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

MVVM (**M**odel **V**iew **V**iew**M**odel) is a fantastic architecture to use with Avalonia and C#.

It may sound complicated, and there are many over complicated guides and tutorials on the internet, but worry not!

MVVM is simply a way to enforce [Separation of concerns](https://en.wikipedia.org/wiki/Separation_of_concerns). For many apps, this may seem overkill. Keeping UI and business logic separated in such a way. However the app that you're building, often start small but can quickly grow. The needs of our project can change rapidly and suddenly and it is in our best interest to not have to shoe horn changes into our code.

Following the MVVM approach will alleviate these difficulties and help keep our UI code scalable.

![MVVM](https://avaloniaui.net/docs/advanced-tutorial/images/mvvm.png)

**How does MVVM work?**

Back to separation of concerns, in any GUI application there are at least 3 main concerns:

* UI - Layout, Style, Content
* UI Logic - How the controls interact with each other and the user.
* Business Logic - The actual functionality your application provides, dealing with a database, controlling some hardware you built for IOT, ordering products from your store.

**Why is it a good idea to keep these separated?**

If your code combines or mixes these 3 aspects together, it will tie the design of your UI directly to your business logic. This will make it incredibly difficult to make large changes to the way your application works. This was common place in the not too distant past.

**How does MVVM achieve this?**

**Model \(Business Logic\)**

All your business logic can be contained in plain classes, they can be designed and implemented however you want. Most project you already may have this. The general term we call these business logic classes is `Models`.

Your models can simply expose `methods` \(functions\), `properties` and use `events` to notify other parts of the MVVM architecture when something has changed in the system.

For example if your domain, is a music store. Perhaps your business logic provides a list of the top 10 albums. It may happen that the list changes and this change can be propagated by use of an `event`.

So now we have the `Model` part of MVVM, all self contained, the `models` know nothing about any of the other parts.

**ViewModel \(UI Logic\)**

Your user interface is essentially the way your `users` interact with your business logic or `models`. There needs to be a way for your UI to interact with the business logic. We do this using a `ViewModel`. A `ViewModel` knows about the `Model` that it represents. It does not know anything about the layout or design of the UI or `View` part.

A `ViewModel` is essentially special type of `Model` that represents all the `data` that will be displayed in the UI. It also represents all the `actions` that can be done with the UI. For example what happens when a button is clicked.

This keeps things like disabling buttons when the user hasnt input the correct information away from your business logic.

A `ViewModel` will `subscribe` to or `observe` events on a model so that it knows when something in your system has changed, with the intention that it can then update the UI so the `user` will know about it.

A `ViewModel` will also call or trigger functionality in response to user input like a `Button` being `clicked`.

**View \(UI\)**

The view provides the layout and content of the UI. It knows about the `ViewModel` and the information it provides that can be displayed in the UI.

The view describes how to "present" data and provides controls the user can interact with.

A `View` can retrieve `data` to display with the use of `Bindings` . `Bindings` can also be used for `interactions` to be communicated back to the `ViewModel` .

**Summary**

A model provides the business logic and talks to the ViewModel.

A ViewModel provides the UI logic and invokes the business logic in response to user input.

A View provides the look, layout and content of the UI.

Lets get started building something!

[Citation source](https://docs.avaloniaui.net/tutorials/music-store-app)
