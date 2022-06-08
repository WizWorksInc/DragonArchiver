using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Xamarin.Essentials;
using DragonArchiver.Core.Models;
using DragonArchiver.Core.ViewModels;

namespace DragonArchiver.Core.Services;

public class ItemService
{
    public List<Item>? ItemList { get; set; }
    private HttpClient _httpClient;
    private const string Url = @"";
    private const string Uri = @"DragonArchiver.Core/Data/JsonData/WOTC_5e_SRD_v5.1";

    public ItemService()
    {
        this._httpClient = new HttpClient();
    }


    public async Task<List<Item>?> GetItems()
    {
        if (ItemList?.Count > 0)
            return ItemList;

        // Online
        /*var response = await httpClient.GetAsync("");
        if (response.IsSuccessStatusCode)
        {
            itemList = await response.Content.ReadFromJsonAsync<List<Item>>();
        }*/
        // Offline
        await using var stream = await FileSystem.OpenAppPackageFileAsync(Uri + "/magicitems.json");
        using var reader = new StreamReader(stream);
        var contents = await reader.ReadToEndAsync();
        ItemList = JsonSerializer.Deserialize<List<Item>>(contents);
        
        return ItemList;
    }
    
    
}
