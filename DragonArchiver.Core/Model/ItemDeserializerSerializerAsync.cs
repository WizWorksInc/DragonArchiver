using Newtonsoft.Json;
using Serilog;

namespace DragonArchiver.Core.Model
{
    /// <summary>
    /// An Asynchronous class for deserializing and serializing Items.
    /// </summary>
    internal class ItemDeserializerSerializerAsync
    {
        /// <summary>
        /// Deserialize the path-ed JSON file and convert it into a list of Items.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>List&lt;Item&gt;</returns>
        public async Task<List<Item>> Deserialize(string path)
        {
            try
            {
                // Prep ourselves for parsing our JSON file
                var json = await File.ReadAllTextAsync(path);
                IList<Item> items = new List<Item>();
                var reader = new JsonTextReader(new StringReader(json));
                reader.SupportMultipleContent = true;

                // Loop through every token in our json
                while (true)
                {
                    // Once we have no more tokens to read this will return false
                    if (!await reader.ReadAsync())
                    {
                        break;
                    }

                    var serializer = new JsonSerializer();
                    var item = serializer.Deserialize<Item>(reader);

                    items.Add(item); // create a deserialized list for us to return
                }

                // Return all of our items as a List<Item> so we can use the data elsewhere
                return items as List<Item>;
            }
            catch (Exception e)
            {
                Log.Error("[ERROR]: {e}", e);
                throw;
            }
        }
    }
}
