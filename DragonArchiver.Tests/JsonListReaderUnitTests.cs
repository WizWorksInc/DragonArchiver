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
        var monsterList = JsonListReader.LoadJsonList<Monster>(Resources.monsters)!;
        var magicItemsList = JsonListReader.LoadJsonList<MagicItem>(Resources.magicitems)!;
        var spellsList = JsonListReader.LoadJsonList<Spell>(Resources.spells)!;
        var racesList = JsonListReader.LoadJsonList<Race>(Resources.races)!;
        
        var testingList = JsonListReader.LoadJsonList<Monster>(Resources.monsters);
        
        Assert.NotEmpty(monsterList);
        Assert.NotEmpty(magicItemsList);
        Assert.NotEmpty(spellsList);
        Assert.NotEmpty(racesList);
        Debug.Assert(testingList != null, nameof(testingList) + " != null");
        Assert.NotEmpty(testingList);
    }
}