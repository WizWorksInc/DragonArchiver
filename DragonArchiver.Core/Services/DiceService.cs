using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DragonArchiver.Core.Services;

/// <summary>
/// Helper class for dice rolls.
/// </summary>
public class DiceService
{
    private readonly Random _random;

    /// <summary>
    /// Accept a new instance of random to help with mocking and testing.
    /// </summary>
    /// <param name="random"></param>
    public DiceService(Random random)
    {
        _random = random;
    }

    /// <summary>
    /// Roll a Die!
    /// </summary>
    /// <remarks>
    /// We really should never roll a die exclusively as all JSON that
    /// is receive should be properly formatted in the 1d20 notation.
    /// </remarks>
    /// <returns>int</returns>
    private int RollDie(int dieFaces) => dieFaces <= 0 ? 0 : _random.Next(1, dieFaces);

    /// <summary>
    /// Roll Dice!
    /// </summary>
    /// <param name="diceFaces"></param>
    /// <param name="amountOfDice"></param>
    /// <returns>List of dice rolls</returns>
    public IEnumerable<int> RollDice(int amountOfDice = 1, int diceFaces = 6)
    {
        for (var i = 0; i < amountOfDice; i++)
            yield return RollDie(diceFaces);
    }

    /// <summary>
    /// Convert a hitpoint dice string to an integer using Regular Expressions.
    /// </summary>
    /// <param name="diceHitpointString">expect a string structured as 1d20 or 1d20+10</param>
    /// <returns>summed amount of hitpoint dice</returns>
    public int ConvertHitpointDiceToIntegerAndSum(string diceHitpointString) 
    {
        /* The following string: (\d+)d(\d+)([\+-]\d+)?$
        * is a Regular Expression.
        *
        * The string is breaking down a hitpoint dice value into its bare components.
        * For example:
        *       We receive a string "1d20+10"
        *       We call Regex.Match() and feed it our string and regular expression pattern
        *       The string is broken down into 4 groups as such:
        *           This breakdown gives a detailed visual view of how the groups of the
        *           regular expression work and how they divide for the Regex.Match function:
        *
        *                   Grouping for breakdown: (1)d(20)((+)(10))
        *                   All values are stored as a string.
        *                   NOTE: (G1) == (Group1)
        *
        *                   (                G0               )
        *                                       (     G3      )
        *                   (G1) [ignored] (G2)   (G4)  (G5)
        *                   (1)      d     (20) ( (+)   (10)  )
        *
        *        We then store this information into diceMatch
        */
        Match diceMatch = Regex.Match(diceHitpointString, @"(\d+)d(\d+)(([\+-])(\d+))?$");
        
        
        /* 
        This expression validates that the string we received is valid integers
        For example: 
        if we were to receive the following string 1d20+10 the string would be broken
        up into multiple groups storing the values as a string.
        
        For reference the string breaks down as follows:
            RegExpression: (\d+)d(\d+)([\+-])(\d+)?$
            (1)[d]((20)(+)(10)) // We ignore [d] as it is not used in the evaluation
            where:
                diceMatch.Groups[1].Value == "1"
                diceMatch.Groups[2].Value == "20"
                diceMatch.Groups[4].Value == "+"
                diceMatch.Groups[5].Value == "10"
        */
        if (int.TryParse(diceMatch.Groups[1].Value, out int amountOfDice) && 
            int.TryParse(diceMatch.Groups[2].Value, out int typeOfDie))
        {
            // Check our operator. We should only see + or - : Then return our modifier with sum
            return diceMatch.Groups[4].Value is "+" or "-" &&
                   int.TryParse(diceMatch.Groups[5].Value, out int diceValueModifier)
                ? diceMatch.Groups[4].Value is "+"
                    ? RollDice(amountOfDice, typeOfDie).Sum() + diceValueModifier
                    : RollDice(amountOfDice, typeOfDie).Sum() - diceValueModifier
                : RollDice(amountOfDice, typeOfDie).Sum(); // If we have no modifiers then return the sum of our dice
        }

        return 0;
    }
}
     
