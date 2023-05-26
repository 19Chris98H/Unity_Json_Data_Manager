using Newtonsoft.Json;
using System.IO;
using UnityEngine;

public static class JsonHelper
{
    public static void LoadJsonResource<T>(ref T destination, string path)
    {
        var textAsset = Resources.Load<TextAsset>(path);
        if (textAsset)
            destination = JsonConvert.DeserializeObject<T>(textAsset.text);
        else
            destination = (T)System.Activator.CreateInstance(typeof(T));
    }
    
    public static void LoadJson<T>(ref T destination, string path)
    {
        if (File.Exists(path))
            destination = JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
        else
            destination = (T)System.Activator.CreateInstance(typeof(T));
    }
    
    public static void SaveJson<T>(T source, string path)
    {
        var directory = path.Remove(path.LastIndexOf('/') + 1);
        if (!Directory.Exists(directory))
            Directory.CreateDirectory(directory);

        using (var file = File.CreateText(path))
        {
            var serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            serializer.Serialize(file, source);
        }
    }
}
