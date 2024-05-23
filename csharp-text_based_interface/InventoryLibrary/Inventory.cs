using System;

/// <summary>
/// Inherits from BaseClass.
/// </summary>
public class Inventory : BaseClass
{
    public int UserId { get; set; }
    public int ItemId { get; set; }

    public int quantity 
    {
        get { return quantity; }
        set { quantity = value >= 0 ? value : 0; }
    }
}