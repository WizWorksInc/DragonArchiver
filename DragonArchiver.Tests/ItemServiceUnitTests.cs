using System.Collections;
using System.Diagnostics;
using DragonArchiver.Core.Models;
using DragonArchiver.Core.Services;
using Xunit.Abstractions;

namespace DragonArchiver.Tests;

public class ItemServiceUnitTests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public ItemServiceUnitTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void TestThatItemServiceIsProperlyReturningAListOfItems()
    {
        ItemService magicItems = new ItemService();
        List<MagicItem>? magicItemsList = magicItems.GetItems();

        //Debug.Assert(magicItemsList != null, nameof(magicItemsList) + " != null");
        Assert.NotEmpty(magicItemsList);


    }
}