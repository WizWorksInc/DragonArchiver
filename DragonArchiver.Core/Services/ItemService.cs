using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
//sing System.Text.Json;
using Newtonsoft.Json.Linq;
//using DragonArchiver.Core.Utils;
using DragonArchiver.Core.Models;
using DragonArchiver.Core.Utils;
using DragonArchiver.Core.ViewModels;
using Newtonsoft.Json;

namespace DragonArchiver.Core.Services;

public class ItemService
{
    //public List<Item>? ItemList { get; set; }
    
    private HttpClient _httpClient;
    private const string Url = @"";
    private const string Uri = @"DragonArchiver.Core/Data/JsonData/WOTC_5e_SRD_v5.1/magicitems.json";
    private string MagicItems = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"DragonArchiver.Core\Data\JsonData\WOTC_5e_SRD_v5.1\magicitems.json");
    
    public ItemService()
    {
        this._httpClient = new HttpClient();
        
    }

    public List<Item>? GetItems()
    {

        return JsonConvert.DeserializeObject<List<Item>>(MagicItems);
    }


}
