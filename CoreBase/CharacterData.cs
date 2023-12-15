using Godot;

namespace CoreBase;

[GlobalClass]
public partial class CharacterData : Resource
{
    [Export] public float Health { get; set; }
    [Export] public float Level { get; set; }
    [Export] public float Resistance { get; set; }
    [Export] public float Mana { get; set; }
    [Export] public float Strength { get; set; }
    [Export] public float Agility { get; set; }
    [Export] public float Intellect { get; set; }
    [Export] public float Fortitude { get; set; }
    [Export] public float Damage { get; set; }
    [Export] public float MovementPoints { get; set; }
    [Export] public Texture Sprite { get; set; }

    public CharacterData()
    {
        Health = 1f;
        Level = 1f;
        Resistance = 1f;
        Mana = 1f;
        Strength = 1f;
        Agility = 1f;
        Intellect = 1f;
        Fortitude = 1f;
        Damage = 1f;
        MovementPoints = 1f;
        Sprite = null;
    }
}
