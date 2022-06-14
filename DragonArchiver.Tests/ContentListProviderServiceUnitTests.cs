using System.Collections;
using System.Diagnostics;
using DragonArchiver.Core.Models;
using DragonArchiver.Core.Services;
using Xunit.Abstractions;

namespace DragonArchiver.Tests;

public class ContentListProviderServiceUnitTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public ContentListProviderServiceUnitTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void TestThatItemServiceIsProperlyReturningAListOfItems()
    {
        //var magicItems = new ContentListProviderService();
        //List<MagicItem>? magicItemsList = magicItems.GetItems();

        //Debug.Assert(magicItemsList != null, nameof(magicItemsList) + " != null");
        //Assert.NotEmpty(magicItemsList!);


    }
}