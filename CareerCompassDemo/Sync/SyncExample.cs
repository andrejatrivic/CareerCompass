namespace CareerCompassDemo.Sync;
public class SyncExample
{
    /// <summary>
    /// Cooks meals sequentially using blocking calls.
    /// Each step pauses the thread for 3 seconds, preventing it from doing any other work.
    /// Total execution time is cumulative (cca 9 seconds).
    /// </summary>
    public void RunSync()
    {
        CookMeal("Burger");
        CookMeal("Pizza");
        CookMeal("Pasta");
    }

    public void CookMeal(string meal)
    {
        Console.WriteLine($"Started cooking: {meal}...");
        Thread.Sleep(3000);
        Console.WriteLine($"Finished cooking: {meal}!");
    }
}
