using System;
using System.Collections.Generic;

namespace CoreBase;

public class CharacterStat
{
    private bool isDirty = true;
    private float _value;

    public float BaseValue;

    private readonly List<StatModifier> statModifiers;
    public CharacterStat(float baseValue)
    {
        BaseValue = baseValue;
        statModifiers = new List<StatModifier>();
    }

    public class StatModifier
    {
        public readonly float Value;
        public StatModifier(float value)
        {
            Value = value;
        }
    }

    public float Value
    {
        get
        {
            if (isDirty)
            {
                _value = CalculateFinalValue();
                isDirty = false;
            }
            return _value;
        }
    }

    public void AddModifier(StatModifier modifier)
    {
        isDirty = true;
        statModifiers.Add(modifier);
    }

    public bool RemoveModifier(StatModifier modifier)
    {
        isDirty = true;
        return statModifiers.Remove(modifier);
    }

    private float CalculateFinalValue()
    {
        float finalValue = BaseValue;

        foreach (StatModifier modifier in statModifiers)
        {
            finalValue += modifier.Value;
        }

        return (float)Math.Round(finalValue, 4);
    }
}