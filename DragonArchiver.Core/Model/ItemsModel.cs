/*using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace DragonArchiver.Core.Model;

public class ItemsModel : ObservableObject
{

    private Item testItem = new Item("slugtest", "nametest", "typetest", "descriptiontest", "raritytest",
        "attunementtest", "documentslugtest", "documenttitletest");

    private readonly Item _item;

    public ItemsModel(Item item) => this._item = item;

    public string Name
    {
        get => _item.Name;
        set => SetProperty(_item.Name, value, _item, (u, n) => u.Name = n);
    }

}*/
