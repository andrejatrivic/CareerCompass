namespace CareerCompassDemo.Async;

public class Async2Example
{
    /// <summary>
    /// Cooks multiple meals concurrently using asynchronous operations.
    /// All meals start at the same time and complete independently.
    /// Total execution time is reduced to the longest single task (cca 3 seconds).
    /// </summary>
    public async Task RunAsync()
    {
        var burger = CookMeal("Burger");
        var pizza = CookMeal("Pizza");
        var pasta = CookMeal("Pasta");

        await Task.WhenAll(burger, pizza, pasta);
    }

    public async Task CookMeal(string meal)
    {
        Console.WriteLine($"Started cooking: {meal}...");
        await Task.Delay(3000);
        Console.WriteLine($"Finished cooking: {meal}!");
    }
}
