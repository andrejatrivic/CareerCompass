namespace CareerCompassWorkshop.Orders;

public class Person1Async
{
    public async Task OrderAsync()
    {
        Console.WriteLine("Person 1 orders Burger and Fries.");
        await Task.Delay(500);
    }

    public async Task PrepareAsync()
    {
        Console.WriteLine("\nPreparing Burger and fries.");

        // TODO: Prepare Burger and fries
    }

    public async Task ServeAsync()
    {
        Console.WriteLine("\nServing Burger and fries...");
        await Task.Delay(1000);
        Console.WriteLine("Burger and fries ready!");
    }

    private async Task CookBurgerAsync()
    {
        Console.WriteLine("Cooking Burger...");
        await Task.Delay(3000);
        Console.WriteLine("Burger ready!");
    }

    private async Task CookFriesAsync()
    {
        Console.WriteLine("Cooking Fries...");
        await Task.Delay(3000);
        Console.WriteLine("Fries ready!");
    }
}

public class Person2Async
{
    public async Task OrderAsync()
    {
        Console.WriteLine("\nPerson 2 orders Pizza.");
        await Task.Delay(500);
    }

    public async Task PrepareAsync()
    {
        Console.WriteLine("\nPreparing Pizza.");

        // TODO: Prepare pizza
    }

    public async Task ServeAsync()
    {
        Console.WriteLine("\nServing Pizza...");
        await Task.Delay(1000);
        Console.WriteLine("Pizza ready!");
    }

    private async Task PrepareDoughAsync()
    {
        Console.WriteLine("Preparing Dough...");
        await Task.Delay(3000);
    }

    private async Task AddSauceAsync()
    {
        Console.WriteLine("Adding Sauce...");
        await Task.Delay(1000);
    }

    private async Task AddCheeseAsync()
    {
        Console.WriteLine("Adding Cheese...");
        await Task.Delay(2000);
    }

    private async Task BakePizzaAsync()
    {
        Console.WriteLine("Baking Pizza...");
        await Task.Delay(4000);
        Console.WriteLine("Pizza ready!");
    }
}

public class DessertAsync
{
    public async Task ServeAsync()
    {
        Console.WriteLine("\nServing Dessert...");
        await Task.Delay(1000);
        Console.WriteLine("Dessert ready!");
    }
}