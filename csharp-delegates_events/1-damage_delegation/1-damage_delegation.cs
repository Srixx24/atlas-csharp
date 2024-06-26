using System;

class Player
{
    private string name { get; set; }
    private float maxHp { get; set; }
    private float hp { get; set; }

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
    
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }

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
    }

    public void HealDamage(float heal)
    {
        heal = Math.Max(heal, 0);
        Console.WriteLine("{0} heals {1} HP!", this.name, heal);
    }
}