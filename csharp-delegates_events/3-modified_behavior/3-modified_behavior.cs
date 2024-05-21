using System;


/// <summary>
/// Delegate for calculating a modifier on a base value.
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);


/// <summary>
/// Enumeration of possible modifiers.
/// </summary>
public enum Modifier
{
    Weak,
    Base,
    Strong
}


/// <summary>
/// Represents a player in the game.
/// </summary>
class Player
{
    private string name { get; set; }
    private float maxHp { get; set; }
    private float hp { get; set; }


    /// <summary>
    /// Initializes a new instance of the <see cref="Player"/> class.
    /// </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }

        this.hp = this.maxHp;
        this.name = name;
    }
    
    /// <summary>
    /// Prints the current health of the player.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }

    /// <summary>
    /// Applies damage to the player.
    /// </summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            Console.WriteLine("{0} takes 0 damage!", this.name);
            damage = 0;
        }
        else
        {
            Console.WriteLine("{0} takes {1} damage!", this.name, damage);
            this.hp -= damage;
        }
        ValidateHP(this.hp);
    }

    /// <summary>
    /// Heals the player.
    /// </summary>
    public void HealDamage(float heal)
    {
        heal = Math.Max(heal, 0);
        Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        ValidateHP(this.hp + heal);
    }

    /// <summary>
    /// Validates the player's health and ensures it stays within range.
    /// </summary>
    public void ValidateHP(float newHp)
    {
        this.hp = Math.Max(0, Math.Min(this.maxHp, newHp));
    }

    /// <summary>
    /// Applies a modifier to a base value strength.
    /// </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return baseValue;
        }
        else if (modifier == Modifier.Base)
        {
            return baseValue;
        }
        else if (modifier == Modifier.Strong)
        {
            return baseValue * 1.5f;
        }
        else
        {
            return baseValue;
        }
    }
}