using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Windows.Input;
using ReactiveUI;


namespace DragonArchiver.Core.ViewModels;

public partial class MainWindowViewModel : AppViewModel
{
    public ObservableCollection<MagicItemViewModel> MagicItems { get; } = new();
    
    private bool _collectionEmpty;
    public MainWindowViewModel()
    {


        this.WhenAnyValue(x => x.MagicItems.Count)
            .Subscribe(x => CollectionEmpty = x == 0);
        
        RxApp.MainThreadScheduler.Schedule(LoadMagicItems);
    }
        public bool CollectionEmpty
        {
            get => _collectionEmpty;
            set => this.RaiseAndSetIfChanged(ref _collectionEmpty, value);
        }
        
        private async void LoadMagicItems()
        {
            var magicItems = await MagicItemViewModel.LoadCached();

            foreach (var item in magicItems)
            {
                MagicItems.Add(item);
            }
        }
    



}