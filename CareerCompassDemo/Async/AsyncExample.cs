namespace CareerCompassDemo.Async;

public class AsyncExample
{
    /// <summary>
    /// Cooks meals sequentially using asynchronous, non-blocking delays.
    /// While waiting, the thread is released back to the runtime instead of being blocked.
    /// Execution is still sequential (cca 9 seconds total), but more efficient for resource usage.
    /// </summary>
    public async Task RunAsync()
    {
        await CookMeal("Burger");
        await CookMeal("Pizza");
        await CookMeal("Pasta");
    }

    public async Task CookMeal(string meal)
    {
        Console.WriteLine($"Started cooking: {meal}...");
        await Task.Delay(3000);
        Console.WriteLine($"Finished cooking: {meal}!");
    }
}
