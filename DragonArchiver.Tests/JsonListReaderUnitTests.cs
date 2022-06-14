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
        var monsterList = JsonListReader.GetJsonList(new Monster(), Resources.monsters)!;
        var magicItemsList = JsonListReader.GetJsonList(new MagicItem(), Resources.magicitems)!;
        var spellsList = JsonListReader.GetJsonList(new Spell(), Resources.spells)!;
        var racesList = JsonListReader.GetJsonList(new Race(), Resources.races)!;
        
        Assert.NotEmpty(monsterList);
        Assert.NotEmpty(magicItemsList);
        Assert.NotEmpty(spellsList);
        Assert.NotEmpty(racesList);
    }
}