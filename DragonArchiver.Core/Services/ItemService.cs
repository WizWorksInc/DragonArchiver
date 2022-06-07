using DragonArchiver.Core.Models;
using DragonArchiver.Core.ViewModels;
using System.Net.Http;

namespace DragonArchiver.Core.Services;

public class ItemService
{
    HttpClient httpClient;
    private string _url;
    private string _uri = @"DragonArchiver.Core/Data/JsonData/WOTC_5e_SRD_v5.1";

    public ItemService()
    {
        this.httpClient = new HttpClient();
    }

    List<Item> itemList;
    public async Task<List<Item>> GetItems()
    {
        if (itemList?.Count > 0)
            return itemList;

        // Online
        /*var response = await httpClient.GetAsync("");
        if (response.IsSuccessStatusCode)
        {
            itemList = await response.Content.ReadFromJsonAsync<List<Item>>();
        }*/
        // Offline
        using var stream = await FileSystem.OpenAppPackageFileAsync(_uri + "/magicitems.json");
        using var reader = new StreamReader(stream);
        var contents = await reader.ReadToEndAsync();
        itemList = JsonSerializer.Deserialize<List<Item>>(contents);
        
        return itemList;
    }
}
