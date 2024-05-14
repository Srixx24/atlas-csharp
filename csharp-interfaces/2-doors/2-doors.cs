using System;

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