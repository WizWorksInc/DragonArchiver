using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace DragonArchiver.Core.Services;

/// <summary>
/// Helper class for dice rolls.
/// </summary>
public class DiceService
{
     private readonly Random _rand = new Random();
     
     /// <summary>
     /// Roll a Die!
     /// </summary>
     /// <returns>int</returns>
     public int RollDice(int dieFaces)
     {
          return dieFaces == 0 ? 0 : _rand.Next(1, dieFaces);
     }

     /// <summary>
     /// Roll multiple Dice!
     /// </summary>
     /// <param name="diceFaces"></param>
     /// <param name="amountOfDice"></param>
     /// <returns>List of dice rolls</returns>
     public List<int> RollDice(int amountOfDice, int diceFaces )
     {
          // Validate we are receiving a valid entry otherwise return 0
          if (amountOfDice <= 0 || diceFaces <= 0)
               return new List<int>() {0};
          
          var returnList = new List<int>();
          for (var i = 0; i < amountOfDice; i++)
               returnList.Add(_rand.Next(1, diceFaces));
          
          return returnList;
     }

     /// <summary>
     /// Convert a hitpoint dice string to an integer using Regular Expressions.
     /// </summary>
     /// <param name="diceHitpointString"></param>
     /// <returns>summed amount of hitpoint dice</returns>
     public int ConvertHitpointDiceToIntegerAndSum(string diceHitpointString)
     {
          /* The following string: (\d+)d(\d+)([\+-]\d+)?$
           * is a Regular Expression.
           *
           * The string is breaking down a hitpoint dice value into its bare components.
           * For example:
           *        We receive a string "1d20"
           *        We call Regex.Match() and feed it our string and regular expression pattern
           *        The string is broken down into 3 groups as such:
           *             (Group1)(Group2)(Group3) == (1)(d)(20)
           *
           *        We then store this information into diceMatch
           */
          // 
          Match diceMatch = Regex.Match(diceHitpointString, @"(\d+)d(\d+)([\+-]\d+)?$");
          try
          {
               /* 
                This expression validates that the string we received is valid integers
                For example: 
                    if we were to receive the following string 1d20
                    we would call diceMatch to pull the value from group 1 which in this case is 1
                    and also call group 2 which in this case is 20.
                    For reference the string breaks down even further as this:
                         (1)[d](20)
                         where:
                              diceMatch.Groups[1].Value == "1"
                              diceMatch.Groups[2].Value == "20"
                */
               if (int.TryParse(diceMatch.Groups[1].Value, out int amountOfDice) &&
                   int.TryParse(diceMatch.Groups[2].Value, out int typeOfDie))
               {
                    return RollDice(amountOfDice, typeOfDie).Sum();
               }
          }
          catch (Exception e)
          {
               Debug.WriteLine(e);
               throw;
          }

          return 0;

     }
     
}