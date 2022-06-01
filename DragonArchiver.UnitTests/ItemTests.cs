using DragonArchiver.Core.Model;
using Xunit;

namespace DragonArchiver.UnitTests
{
    // TODO: Implement item unit testing when Items are actually complete to a degree
    public class ItemTests
    {
	    public ItemTests()
	    {
		    
	    }

        [Fact]
        public void TestDeserializationForItems()
        {
	        var itemDeserializer = new ItemDeserializerSerializerAsync();
	        Assert.IsType<Item>(itemDeserializer.Deserialize(
		        @"C:\_Projects\DragonArchiver\DragonArchiver.Core\Resources\json\data\WOTC_5e_SRD_v5.1\magicitems.json"));
        }
    }
}
