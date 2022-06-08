using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using DragonArchiver.Core.Models;
using DragonArchiver.Core.Services;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Xamarin.Essentials;

namespace DragonArchiver.Core.ViewModels;

public partial class ItemsViewModel : BaseViewModel
{
    
    public ObservableCollection<Item> Items { get; } = new();
    private ItemService _itemService;
    public ItemsViewModel()
    {
        Title = "Item List";
        this._itemService = new ItemService();
    }

    [ObservableProperty] private bool _isRefreshing;
    

    public async Task GetItemsAsync()
    {
        if (IsBusy)
            return;

        try
        {

            IsBusy = true;
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
            IsBusy = false;
            IsRefreshing = false;
        }

    }    
}