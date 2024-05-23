using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;


public class JSONStorage
{
    private Dictionary<string, object> objects = new Dictionary<string, object>();
    private string fileLocat = "storage/inventory_manager.json";

    public void All()
    {
        return (this.objects);
    }

    public void New(object obj)
    {
        string key = $"{obj.GetType().Name}.{obj.GetHashCode()}";
        this.objects.Add(key, obj);
    }

    public void Save()
    {
        string jsonSaves = JsonSerializer.Serialize(this.objects);
        Directory.CreateDirectory("storage");
        File.WriteAllText(fileLocat, jsonSaves);
    }

    public void Load()
    {
        if (File.Exist(fileLocat))
        {
            string jsonLoads = File.ReadAllText(fileLocat);
            objects = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonLoads);
        }
    }
}