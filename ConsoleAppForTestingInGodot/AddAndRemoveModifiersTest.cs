using CoreBase.Character.Stats;

namespace ConsoleAppForTestingProjectDream;

public class AddAndRemoveModifiersTest
{
    public void Test()
    {
        CharacterStat stat = new CharacterStat(10f);

        // Test AddModifier
        CharacterStat.StatModifier modifier = new CharacterStat.StatModifier(5f);
        stat.AddModifier(modifier);
        Console.WriteLine($"Value after adding modifier: {stat.Value}");

        // Test RemoveModifier
        bool wasRemoved = stat.RemoveModifier(modifier);
        Console.WriteLine($"Was modifier removed? {wasRemoved}");
        Console.WriteLine($"Value after removing modifier: {stat.Value}");
    }


}
