using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DragonArchiver.Core.Models;
using JetBrains.Annotations;
using System.Text.Json;
using System.Threading.Tasks;

namespace DragonArchiver.Core.Utils;

public static class JsonListReader
{
    /// <summary>
    /// Take an object type and a string of JSON and return an IEnumerable List of objects.
    /// </summary>
    /// <param name="resourceType"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns>IEnumerable</returns>
    public static IEnumerable<T>? LoadJsonList<T>(string resourceType)
    {
        return JsonSerializer.Deserialize<IEnumerable<T>>(resourceType);
    }
    
    /// <summary>
    /// Take an object type and a string of JSON and asynchronously return an IEnumerable List of objects.
    /// </summary>
    /// <param name="resourceType"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static async Task<IEnumerable<T>?> LoadJsonAsync<T>(string resourceType)
    {
        // Convert our string of JSON to a stream so we can async
        using var stream = new MemoryStream(Encoding.UTF8.GetBytes(resourceType));
        
        return await JsonSerializer.DeserializeAsync<IEnumerable<T>>(stream);
    }
}
