using System.Diagnostics;
using DragonArchiver.Core;
using DragonArchiver.Core.Models;

namespace DragonArchiver.Tests;
using Core.Utils;

public class JsonListReaderUnitTests
{
    [Fact]
    public void CheckAllJsonFilesAndVerifyWorking()
    {
        var monsterList = JsonHandler.LoadJsonList<IEnumerable<Monster>>(Resources.monsters)!;
        var magicItemsList = JsonHandler.LoadJsonList< IEnumerable<MagicItem>>(Resources.magicitems)!;
        var spellsList = JsonHandler.LoadJsonList< IEnumerable<Spell>>(Resources.spells)!;
        var racesList = JsonHandler.LoadJsonList< IEnumerable<Race>>(Resources.races)!;
        
        var testingList = JsonHandler.LoadJsonList< IEnumerable<Monster>>(Resources.monsters);
        
        Assert.NotEmpty(monsterList);
        Assert.NotEmpty(magicItemsList);
        Assert.NotEmpty(spellsList);
        Assert.NotEmpty(racesList);
        Debug.Assert(testingList != null, nameof(testingList) + " != null");
        Assert.NotEmpty(testingList);
    }
}