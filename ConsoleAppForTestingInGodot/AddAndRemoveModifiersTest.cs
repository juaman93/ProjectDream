﻿using CoreBase.Character.Stat;
using static CoreBase.Character.Stat.CharacterStat;

namespace ConsoleAppForTestingProjectDream;

public class AddAndRemoveModifiersTest
{
    public void Test()
    {
        CharacterStat stat = new CharacterStat(10f);

        // Test AddModifier
        StatModifier modifier = new StatModifier(5f, StatModType.Flat);
        stat.AddModifier(modifier);
        Console.WriteLine($"Value after adding modifier: {stat.Value}");

        // Test RemoveModifier
        bool wasRemoved = stat.RemoveModifier(modifier);
        Console.WriteLine($"Was modifier removed? {wasRemoved}");
        Console.WriteLine($"Value after removing modifier: {stat.Value}");
    }


}