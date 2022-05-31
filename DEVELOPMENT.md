# Development Guide (UNDER CONSTRUCTION)

Dragon Archiver is built using .Net Maui and closely adheres to the Model-View-ViewModel (MVVM) architecture. This allows us to decouple our application so that extensibility is easier in the long run. As such you are expected to adhere to this design principle also at all times. Failure to file this architecture could possibly lead to any PR made to the repo to be declined. So please adhere!
If you need any help on the topic feel free to ask questions!

## Guidelines to Follow
- Always adhere to the Model-View-ViewModel (MVVM) architecture
- When creating something new always look that you are following DRY (Don't Repeat Yourself)
- Remember KISS, keep it simple stupid!
- Always aim to avoid coupling your code! We should generally we decoupling than coupling.
- Do what the Boy Scouts do when you are working on code. Leave it better than you found it!
- Documenting your code is important but it is detrimental to over document. If code does not make logical sense then it may need to be documented!
- We follow the Clean Code Philosophy and you should too! As such when naming variables or writing code what is happening should make logical sense from just a glance. So name your variables robustly and write code that is easy to read!
- If you ever are lost or confused don't be afraid to ask for help!

> These guidelines are mostly suggestions not requirements but failure to follow the guide lines could lead to your Pull Request getting declined or asked for changes. So generally it is in your best interest to follow these guidelines to the best of your ability!

## Building

1. Fork the `dev` branch as a personal repository.
2. Clone your forked repository.
3. Run `RUN_THIS.py` to init submodules.
4. Compile the solution.
