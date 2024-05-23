using System;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>
/// Base class that all other classes will inherit from.
/// </summary>
public class BaseClass
{
    public string id { get; set; }
    public DateTime date_created { get; set; }
    public DateTime date_updated { get; set; }
}