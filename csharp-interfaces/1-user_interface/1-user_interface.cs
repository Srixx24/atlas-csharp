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

class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability;
    public bool isCollected;

    public void Interact()
    {

    }
    
    public void Break()
    {

    }

    public Collect()
    {

    }
}