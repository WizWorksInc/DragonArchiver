using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using DragonArchiver.Core.Models;
using System.Linq;
using DragonArchiver.Core.Utils;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace DragonArchiver.Core.ViewModels;

public partial class MagicItemViewModel : BaseViewModel
{

    private readonly MagicItem _magicItem;
    public MagicItemViewModel(MagicItem magicItem)
    {
        _magicItem = magicItem;
    }

    public string Name => _magicItem.Name;
    public string Description => _magicItem.Description;
    public string Type => _magicItem.Type;
    public string Rarity => _magicItem.Rarity;
    public string? RequiresAttunement => _magicItem.RequiresAttunement;


    public static async Task<IEnumerable<MagicItemViewModel>> LoadCached()
    {
        return ((await MagicItem.LoadContentListAsync())!).Select(x => new MagicItemViewModel(x));
    }
    

    // Deserialize our magicitems.json into a IEnumerable so we can store it in an observable collection
    // This will help us later when calling the list for use
    private static readonly IEnumerable<MagicItem>? MagicItems =
        JsonHandler.LoadJsonList<IEnumerable<MagicItem>>(Resources.magicitems);

    private ObservableCollection<MagicItem> _magicItemsList = new(MagicItems ?? Array.Empty<MagicItem>());
    public ObservableCollection<MagicItem> MagicItemsList
    {
        get => _magicItemsList;
        set => this.RaiseAndSetIfChanged(ref _magicItemsList, value);
    }
}