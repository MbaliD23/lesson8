using System;
using System.Net.Http;
using System.Threading.Tasks;

public static class Lesson12_4_StartNowAwaitLater
{
    public static async Task Run()
    {
        using var http = new HttpClient();

        Console.WriteLine("A) Starting download...");

        // TODO: start GetStringAsync, store it in a Task<string> variable (do NOT await yet)
        Task<string> downloadTask = http.GetStringAsync("https://example.com");

        // TODO: print "B) Doing something else..."
        Console.WriteLine("B) Doing something else...");

        // Just showing the app can keep moving while the download is running
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"   Busy with something else... step {i}");
        }

        // TODO: await the task and print "C) Done!" + length
        string html = await downloadTask;
        Console.WriteLine($"C) Done! Downloaded length: {html.Length}");

        // SA student note:
        // I used a tiny loop as “other work” so you can see the flow properly,
        // otherwise it looks like A then immediately C and you miss the point of storing the Task.
    }
}
