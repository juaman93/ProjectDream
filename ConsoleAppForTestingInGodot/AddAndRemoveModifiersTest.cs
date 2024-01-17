using CoreBase.Character;
using static CoreBase.Character.CharacterStat;

namespace ConsoleAppForTestingProjectDream;

public class AddAndRemoveModifiersTest
{
    public void Test()
    {
        CharacterStat charStat = new CharacterStat(100f); // Initialize a CharacterStat with a base value of 100

        charStat.AddModifier(new CharacterStat.StatModifier(50f, CharacterStat.StatModType.Flat)); // Add a flat modifier of 50
        charStat.AddModifier(new CharacterStat.StatModifier(0.1f, CharacterStat.StatModType.PercentAdd)); // Add a percent add modifier of 10%
        Console.WriteLine($"Final value of CharacterStat: {charStat.Value}");

        charStat.RemoveModifier(charStat.StatModifiers[0]); // Remove the first modifier
        Console.WriteLine($"Final value of CharacterStat after removing the first modifier: {charStat.Value}");

        charStat.RemoveAllModifiersFromSource(null); // Remove all modifiers
        Console.WriteLine($"Final value of CharacterStat after removing all modifiers: {charStat.Value}");
    }


}