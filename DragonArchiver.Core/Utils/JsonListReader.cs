using System.Collections;
using System.Collections.Generic;
using DragonArchiver.Core.Models;
using Newtonsoft.Json;

namespace DragonArchiver.Core.Utils;

public class JsonListReader
{
    public static List<T>? GetJsonList<T>(T obj , string resourceType)
    {
        return JsonConvert.DeserializeObject<List<T>>(resourceType);
    }
}