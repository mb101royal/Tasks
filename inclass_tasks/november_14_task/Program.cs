using System;
using System.IO;
using System.Reflection.Metadata;
using System.Text.Json;

class CustomObject
{
    public int userId { get; set; }
    public int id { get; set; }
    public string? title { get; set; }
    public string? body { get; set; }
}

class Program
{
    public static string Root = @"C:\Users\Birinci novbe\source\repos\pushable\november_14_task";
    static async Task Main(string[] args)
    {
        string models = @$"{Root}\Models";
        string data = @$"{Root}\Data";
        string jsonFile = @$"{data}\jsonData.json";

        if (!Directory.Exists(models))
        {
            Directory.CreateDirectory(models);
        }
        if (!Directory.Exists(data))
        {
            Directory.CreateDirectory(data);
        }

        if (!File.Exists(jsonFile))
        {
            File.Create(jsonFile);
        }

        HttpClient client = new HttpClient();
        List<string> urls = new List<string>();
        urls.Add("https://jsonplaceholder.typicode.com/posts");

        List< CustomObject > customObjects = new List< CustomObject >();

        foreach (var url in urls)
        {
            string? content = await client.GetStringAsync(url);

            string outputFilePath = jsonFile;

            customObjects = JsonSerializer.Deserialize<List<CustomObject>>(content);
            string customObjectsString = JsonSerializer.Serialize(customObjects);
            
            File.WriteAllText(outputFilePath, customObjectsString);
        }
    }
}