using System;
using System.Threading.Tasks;

public static class Lesson12_2_TryCatchAwait
{
    public static async Task Run()
    {
        var contentService = new ContentService();

        // TODO:
        // 1) Wrap the awaited call in try/catch
        // 2) Print html.Length on success
        // 3) Print a friendly message and ex.Message on failure

        try
        {
            string html = await contentService.GetWebsiteContentAsync("https://example.com");
            Console.WriteLine($"HTML length: {html.Length}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Eish, I couldn't fetch the website content.");
            Console.WriteLine($"Reason: {ex.Message}");

            // SA student note:
            // I printed a friendly message + ex.Message so you see what went wrong,
            // but it still looks user-friendly and doesn't crash the whole app.
        }
    }
}