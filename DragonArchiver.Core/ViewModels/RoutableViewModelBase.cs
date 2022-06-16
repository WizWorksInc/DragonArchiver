using System;
using System.Reactive;
using ReactiveUI;

namespace DragonArchiver.Core.ViewModels;

public abstract class RoutableViewModelBase : ReactiveObject, IRoutableViewModel
{
    // Reference to IScreen that owns the routable view model.
    public IScreen HostScreen { get; }

    // Unique identifier for the routable view model.
    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);

    public RoutableViewModelBase(IScreen screen) => HostScreen = screen;
}

