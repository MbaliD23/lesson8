using Lesson_8;
using System;
using System.Threading.Tasks;

public static class Lesson12Runner
{
    public static async Task Run()
    {
        Console.WriteLine("=== Mini Exercises 12 ===");

        Console.WriteLine("\n--- 12.1 Convert sync file read to async ---");
        await Lesson12_1_FileReadAsync.Run();

        Console.WriteLine("\n--- 12.2 Add exception handling around an awaited call ---");
        await Lesson12_2_TryCatchAwait.Run();

        Console.WriteLine("\n--- 12.3 Classify work as I/O-bound or CPU-bound ---");
        Lesson12_3_ClassifyWork.Run();

        Console.WriteLine("\n--- 12.4 Start a task now, await later ---");
        await Lesson12_4_StartNowAwaitLater.Run();

        Console.WriteLine("\n=== Done ===");
    }
}
