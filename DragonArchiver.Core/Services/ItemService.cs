using DragonArchiver.Core.Model;

namespace DragonArchiver.Core.Services;

public class ItemService
{
    List<Item> itemList = new();
    public async Task<List<Item>> GetItems()
    {
        return itemList;
    }
}
