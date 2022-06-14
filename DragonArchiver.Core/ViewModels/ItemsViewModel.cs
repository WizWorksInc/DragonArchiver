using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using DragonArchiver.Core.Models;
using DragonArchiver.Core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Avalonia.Media.Imaging;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace DragonArchiver.Core.ViewModels;

public partial class ItemsViewModel : ViewModelBase
{
    private static ItemService _itemService;

    private ObservableCollection<MagicItem> _itemsList = new ObservableCollection<MagicItem>(_itemService.GetItems());
    public ObservableCollection<MagicItem> ItemsList
    {
        get => _itemsList;
        set => this.RaiseAndSetIfChanged(ref _itemsList, value);
    }

    private readonly MagicItem _item;
    // public ItemsViewModel(Item item)
    // {
    //     _item = item;
    // }
    
    // // This attribute [Reactive] enables property change notifications.
    // [Reactive] public string Name { get; set; }
    // [Reactive] public string Description { get; set; }
    // [Reactive] public string Type { get; set; }
    // [Reactive] public string Rarity { get; set; }
    // [Reactive] public string? RequiresAttunement { get; set; }


    

    public async Task GetItemsAsync()
    {
        //if (IsBusy)
            //return;

        try
        {

            //IsBusy = true;
            //var items = await _itemService.GetItems();

            // if(Items.Count != 0)
            //     Items.Clear();

            //foreach(var item in items)
                //Items.Add(item);

        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to get items: {ex.Message}");
            
        }
        finally
        {
            //IsBusy = false;
            //IsRefreshing = false;
        }

    }    
}