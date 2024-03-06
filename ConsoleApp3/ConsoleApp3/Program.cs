using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> data = new Dictionary<string, List<string>>
        {
            { "key1", new List<string> { "qw", "er", "ty" } },
            { "key2", new List<string> { "ui", "op", "as" } }
        };

        List<string> mergedList = MergeDictionaryValues(data);
        mergedList.Sort();

        string json = JsonSerializer.Serialize(mergedList, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("output.json", json);

        Console.WriteLine("Результат було збережено у файлі output.json");
    }

    static List<string> MergeDictionaryValues(Dictionary<string, List<string>> data)
    {
        List<string> mergedList = new List<string>();

        foreach (var entry in data)
        {
            mergedList.AddRange(entry.Value);
        }

        return mergedList;
    }
}


