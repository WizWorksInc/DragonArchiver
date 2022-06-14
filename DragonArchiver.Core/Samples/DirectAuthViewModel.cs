using System;
using System.Reactive;
using System.Threading.Tasks;
using DragonArchiver.Core.ViewModels;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using ReactiveUI.Validation.Extensions;
using ReactiveUI.Validation.Helpers;

namespace DragonArchiver.Core.Samples;

/// <summary>
/// Sample viewmodel showcasing key features in Avalonia and ReactiveUI.
/// </summary>
public class DirectAuthViewModel : ViewModelBase // Viewmodel base is a ReactiveValidationObject
{
    [Reactive] // This attribute enables property change notifications.
    public string Username { get; set; }
    [Reactive] // This attribute enables property change notifications.
    public string Password { get; set; }
    
    public ReactiveCommand<Unit, Unit> Login { get; }

    public DirectAuthViewModel()
    {
        this.ValidationRule(x => x.Username,
            name => !string.IsNullOrWhiteSpace(name),
            "Username should not be null or white space.");
        this.ValidationRule(x => x.Password,
            pass => !string.IsNullOrWhiteSpace(pass),
            "Password should not be null or white space.");
        // IObservable<bool> canLogin =
        //     // Here we listen to property change notifications
        //     // of Username and Password properties.
        //     this.WhenAnyValue(
        //         x => x.Username, x => x.Password,
        //         (username, password) =>
        //             !string.IsNullOrWhiteSpace(username) &&
        //             !string.IsNullOrWhiteSpace(password));
        Login = ReactiveCommand.CreateFromTask(
            execute: () => Task.Delay(TimeSpan.FromSeconds(1)),
            canExecute: this.IsValid());
    }
}