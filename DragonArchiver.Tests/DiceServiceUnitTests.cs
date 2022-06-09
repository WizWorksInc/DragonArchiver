using DragonArchiver.Core.Services;

namespace DragonArchiver.Tests;

public class DiceServiceUnitTests
{
    [Fact]
    public void Validate_RollDice_Is_Returning_An_Integer_Or_List()
    {
        var diceServiceTesting = new DiceService();
        
        Assert.InRange(diceServiceTesting.RollDice(20), 1, 20);
        Assert.Collection(diceServiceTesting.RollDice(1, 1), x => { });
    }
    
    [Fact]
    public void Validate_ConvertHitpointDiceToIntegerAndSum_Is_Properly_Returning_An_Integer()
    {
        var diceServiceTesting = new DiceService();
        const string mustReturn0 = "0d123";
        const string mustReturn1 = "1d1";
        const string mustReturnValueBetween1And20 = "1d20";
        const string mustReturnValueBetween10And200 = "10d20";
        const string mustReturnValueBetween1And100 = "1d100";
        const string mustReturnValueBetween1And10000 = "1d10000";
        const string mustReturnValueBetween100And100000 = "100d1000";
        
        Assert.Equal(0, diceServiceTesting.ConvertHitpointDiceToIntegerAndSum(mustReturn0));
        Assert.Equal(1, diceServiceTesting.ConvertHitpointDiceToIntegerAndSum(mustReturn1));
        Assert.InRange(diceServiceTesting.ConvertHitpointDiceToIntegerAndSum(mustReturnValueBetween1And20), 1, 20);
        Assert.InRange(diceServiceTesting.ConvertHitpointDiceToIntegerAndSum(mustReturnValueBetween10And200), 10, 200);
        Assert.InRange(diceServiceTesting.ConvertHitpointDiceToIntegerAndSum(mustReturnValueBetween1And100), 1, 100);
        Assert.InRange(diceServiceTesting.ConvertHitpointDiceToIntegerAndSum(mustReturnValueBetween1And10000), 1, 10000);
        Assert.InRange(diceServiceTesting.ConvertHitpointDiceToIntegerAndSum(mustReturnValueBetween100And100000), 100, 100000);
        
    }
}