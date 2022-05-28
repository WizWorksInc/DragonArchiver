using DragonArchiver.Core.Model;

namespace DragonArchiver.Core.Services;

public class ItemService
{
    List<Item> itemList = new();
    public Task<List<Item>> GetItems()
    {
        return Task.FromResult(itemList);
    }
}
