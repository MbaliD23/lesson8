using System;
using System.IO;
using System.Threading.Tasks;

public static class Lesson12_1_FileReadAsync
{
    public static async Task Run()
    {
        // Making a small file so the demo actually works when you run it
        string path = "config.txt";
        File.WriteAllText(path, "mode=dev\nregion=ZA\n");

        var loader = new ConfigLoader();

        // TODO:
        // 1) Rename this to LoadConfigAsync
        // 2) Change the return type to Task<string>
        // 3) Use File.ReadAllTextAsync(path)

        string config = await loader.LoadConfigAsync(path);

        Console.WriteLine("Config loaded:");
        Console.WriteLine(config);

        // SA student note:
        // I made a quick config.txt here because otherwise the method runs,
        // but you might not have a file to test with and it looks like it’s broken.
    }
}

public class ConfigLoader
{
    // Keeping the sync version just in case older code still uses it
    public string LoadConfig(string path)
    {
        return File.ReadAllText(path);
    }

    // TODO:
    // 1) Rename this to LoadConfigAsync
    // 2) Change the return type to Task<string>
    // 3) Use File.ReadAllTextAsync(path)

    public async Task<string> LoadConfigAsync(string path)
    {
        // Async file read so the thread isn't blocked while waiting for disk
        return await File.ReadAllTextAsync(path);
    }
}
