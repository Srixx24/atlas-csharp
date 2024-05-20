using System;

class Player
{
    private string name { get; set; }
    private float maxHp { get; set; }
    private float hp { get; set; }

    public Player(string name, float maxHp)
    {
        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.")
        }
        else
        {
            this.maxHp = maxHp;
        }

        this.hp = this.maxHp;
        this.name = string.IsNullOrEmpty(name) ? "Player" : name;
    }
    
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }
}