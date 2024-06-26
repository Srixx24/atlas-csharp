using System;
using System.Collections.Generic;

abstract class Base
{
    public string name = "";

    public override string ToString()
    {
        return $"{name} is a {GetType().Name}";
    } 
}

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

class Door : Base, IInteractive
{
    public Door(string name = "Door")
    {
        this.name = name;
    }

    public void Interact()
    {
        Console.WriteLine("You try to open the {0}. It's locked.", name);
    }
}

class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem { get; set; }
    public int durability { get; set; }

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception ("Durability must be greater than 0");
        }

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine("The {0} has been broken.", name);
        }
        else if (isQuestItem)
        {
            Console.WriteLine("You look at the {0}. There's a key inside.", name);
        }
        else
        {
            Console.WriteLine("You look at the {0}. Not much to see here.", name);
        }
    }

    public void Break()
    {
        durability--;
        
        if (durability > 0)
        {
            Console.WriteLine("You hit the {0}. It cracks.", name);
        }
        else if (durability == 0)
        {
            Console.WriteLine("You smash the {0}. What a mess.", name);
        }
        else if (durability < 0)
        {
            Console.WriteLine("The {0} is already broken.", name);
        }
    }
}

class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    public void Collect()
    {
        if (isCollected)
        {
            Console.WriteLine("You have already picked up the {0}.", name);
        }
        else
        {
            isCollected = true;
            Console.WriteLine("You pick up the {0}.", name);
        }
    }
}

class RoomObjects
{
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (Base item in roomObjects)
        {
            if (type.IsInstanceOfType(item))
            {
                if (type == typeof(IInteractive))
                {
                    ((IInteractive)item).Interact();
                }
                if (type == typeof(IBreakable))
                {
                    ((IBreakable)item).Break();
                }
                if (type == typeof(ICollectable))
                {
                    ((ICollectable)item).Collect();
                }
            }
        }
    }
}