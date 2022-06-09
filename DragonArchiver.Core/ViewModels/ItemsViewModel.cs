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

namespace DragonArchiver.Core.ViewModels;

public partial class ItemsViewModel : ViewModelBase
{
    
    public ObservableCollection<Item> Items { get; } = new();
    private ItemService _itemService;
    private readonly Item _item;
    public ItemsViewModel(Item item)
    {
        _item = item;
    }
    
    public string Name => _item.Name;
    public string Description => _item.Desc;


    

    public async Task GetItemsAsync()
    {
        //if (IsBusy)
            //return;

        try
        {

            //IsBusy = true;
            var items = await _itemService.GetItems();

            if(Items.Count != 0)
                Items.Clear();

            foreach(var item in items)
                Items.Add(item);

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