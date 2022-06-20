using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DragonArchiver.Core.Utils;

public static class JsonHandler
{
    // Internal variables used for some methods
    internal static readonly string CustomDocPath =
        Path.Combine(Environment.SpecialFolder.Personal.ToString(), "DragonArchiver");
    internal static readonly JsonSerializerOptions Options = new() { WriteIndented = true };

    /// <summary>
    /// Take an object type and a string of JSON and return an IEnumerable List of objects.
    /// </summary>
    /// <param name="resourceType"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns>IEnumerable</returns>
    public static T? LoadJsonList<T>(string resourceType)
    {
        return JsonSerializer.Deserialize<T>(resourceType);
    }
    
    /// <summary>
    /// Take an object type and a string of JSON and asynchronously return an IEnumerable List of objects.
    /// </summary>
    /// <param name="resourceType"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static async Task<T?> LoadJsonAsync<T>(string resourceType)
    {
        // Convert our string of JSON to a stream so we can async
        await using var stream = new MemoryStream(Encoding.UTF8.GetBytes(resourceType));

        return await JsonSerializer.DeserializeAsync<T>(stream);
    }


    /// <summary>
    /// Create a custom JSON file for the given object type. Then save it to the users personal folder.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="listOfObjects"></param>
    /// <param name="fileName"></param>
    public static void SaveCustomJson<T> (T listOfObjects, string fileName)
    {
        var jsonString = JsonSerializer.Serialize(listOfObjects, Options);
        File.WriteAllText(Path.Combine(CustomDocPath, $"{fileName}.json"), jsonString);
    }

    /// <summary>
    /// Asynchronously create a custom JSON file for the given object type. Then save it to the users personal folder.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="listOfObjects"></param>
    /// <param name="fileName"></param>
    public static async void SaveCustomJsonAsync<T>(T listOfObjects, string fileName)
    {
        await using var createStream = File.Create(Path.Combine(CustomDocPath, $"{fileName}.json"));
        await JsonSerializer.SerializeAsync(createStream, listOfObjects, Options);
    }

    /// <summary>
    /// Load a custom JSON file from the users personal folder and deserialize it.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="fileName"></param>
    /// <returns>T</returns>
    public static T? LoadCustomJson<T>(string fileName)
    {
        return JsonSerializer.Deserialize<T>(Path.Combine(CustomDocPath, $"{fileName}.json"));
    }

    /// <summary>
    /// Asynchronously load a custom JSON file from the users personal folder and deserialize it.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="fileName"></param>
    /// <returns>T</returns>
    public static async Task<T?> LoadCustomJsonAsync<T>(string fileName)
    {
        // Convert our string of JSON to a stream so we can async
        await using var stream = new MemoryStream(Encoding.UTF8.GetBytes(Path.Combine(CustomDocPath, $"{fileName}.json")));
        return await JsonSerializer.DeserializeAsync<T>(stream);
    }

    /// <summary>
    /// Delete any json file in our personal folder.
    /// </summary>
    /// <param name="fileName"></param>
    public static bool DeleteCustomJsonFile(string fileName)
    {
        if (File.Exists(Path.Combine(CustomDocPath, $"{fileName}.json")))
        {
            File.Delete(Path.Combine(CustomDocPath, $"{fileName}.json"));
            return true;
        }

        // Check if the directory exists and is empty. If so then we delete it.
        if (!Directory.EnumerateFileSystemEntries(CustomDocPath).Any() && Directory.Exists(CustomDocPath))
            File.Delete(CustomDocPath);


        return false;
    }

}
