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
    /// <summary>
    /// Weak modifier.
    /// </summary>
    Weak,
    /// <summary>
    /// Base modifier.
    /// </summary>
    Base,
    /// <summary>
    /// Strong modifier.
    /// </summary>
    Strong
}

/// <summary>
/// Represents the current health of a player.
/// </summary>
class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// The current hp of the Player
    /// </summary>
    public float currentHp { get; }

    /// <summary>
    /// Initializes a new instance
    /// </summary>
    /// <param name="newHp">The new HP of the Player</param>
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}


/// <summary>
/// Represents a player in the game.
/// </summary>
class Player
{
    private string name { get; set; }
    private float maxHp { get; set; }
    private float hp { get; set; }
    private string status { get; set; }


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
        this.status = $"{name} is ready to go!";
        HPCheck += CheckStatus;
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
    /// An event that is raised when the player's health changes.
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>
    /// Raises the HPCheck event.
    /// </summary>
    protected virtual void OnHPCheck(CurrentHPArgs e)
    {
        HPCheck?.Invoke(this, e);
    }

    /// <summary>
    /// Validates the player's health and ensures it stays within range.
    /// </summary>
    public void ValidateHP(float newHp)
    {
        this.hp = Math.Max(0, Math.Min(this.maxHp, newHp));
        OnCheckStatus(new CurrentHPArgs(this.hp, this.maxHp));
    }

    /// <summary>
    /// Updates the player's status based on their current health.
    /// </summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
        {
            this.status = $"{this.name} is in perfect health!";
        }
        else if (e.currentHp >= this.maxHp / 2 && e.currentHp < this.maxHp)
        {
            this.status = $"{this.name} is doing well!";
        }
        else if (e.currentHp >= this.maxHp / 4 && e.currentHp < this.maxHp / 2)
        {
            this.status = $"{this.name} isn't doing too great...";
        }
        else if (e.currentHp > 0 && e.currentHp < this.maxHp / 4)
        {
            this.status = $"{this.name} needs help!";
        }
        else
        {
            this.status = $"{this.name} is knocked out!";
        }

        Console.WriteLine(this.status);
    }

    /// <summary>
    /// Checks the player's health and triggers event if health is low.
    /// </summary>
    private void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < this.maxHp / 4)
        {
            this.HPCheck += this.HPValueWarning;
        }
        OnHPCheck(e);
    }

    /// <summary>
    /// Prints a warning if the player's health is low or has reached zero.
    /// </summary>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.WriteLine("Health has reached zero!");
        }
        else if (e.currentHp < this.maxHp / 4)
        {
            Console.WriteLine("Health is low!");
        }
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