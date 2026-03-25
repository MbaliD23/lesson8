using System;

public static class Lesson12_3_ClassifyWork
{
    public static void Run()
    {
        // TODO: Classify each one as either I/O-bound or CPU-bound
        // - File.ReadAllTextAsync(...)
        // - HttpClient.GetStringAsync(...)
        // - summing 1 to 50 million in a loop
        // - a database query

        Console.WriteLine("File.ReadAllTextAsync(...) -> I/O-bound (disk)");
        Console.WriteLine("HttpClient.GetStringAsync(...) -> I/O-bound (network)");
        Console.WriteLine("Summing 1 to 50 million -> CPU-bound (calculations)");
        Console.WriteLine("Database query -> I/O-bound (waiting on DB/network/disk)");

        // SA student note:
        // Database queries can feel like “work”, but most of the time your app is just waiting
        // for the DB to respond, so it counts as I/O-bound.
    }
}