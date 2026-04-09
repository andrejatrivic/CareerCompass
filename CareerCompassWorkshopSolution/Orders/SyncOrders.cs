namespace CareerCompassWorkshopSolution.Orders;

public class Person1Sync
{
    public void Order()
    {
        Console.WriteLine("Person 1 orders Burger and Fries.");       
    }

    public void Prepare()
    {
        Console.WriteLine("\nPreparing Burger and fries.");

        CookBurger();
        CookFries();
    }

    public void Serve()
    {
        Console.WriteLine("\nServing Burger and fries...");
        Thread.Sleep(1000);
        Console.WriteLine("Burger and fries ready!");
    }

    private void CookBurger()
    {
        Console.WriteLine("Cooking Burger...");
        Thread.Sleep(3000);
        Console.WriteLine("Burger ready!");
    }

    private void CookFries()
    {
        Console.WriteLine("Cooking Fries...");
        Thread.Sleep(3000);
        Console.WriteLine("Fries ready!");
    }
}

public class Person2Sync
{
    public void Order()
    {
        Console.WriteLine("\nPerson 2 orders Pizza.");        
    }

    public void Prepare()
    {
        Console.WriteLine("\nPreparing Pizza.");

        PrepareDough();
        AddSauce();
        AddCheese();
        BakePizza();
    }

    public void Serve()
    {
        Console.WriteLine("\nServing Pizza...");
        Thread.Sleep(1000);
        Console.WriteLine("Pizza ready!");
    }

    private void PrepareDough()
    {
        Console.WriteLine("Preparing Dough...");
        Thread.Sleep(3000);
    }

    private void AddSauce()
    {
        Console.WriteLine("Adding Sauce...");
        Thread.Sleep(1000);
    }

    private void AddCheese()
    {
        Console.WriteLine("Adding Cheese...");
        Thread.Sleep(2000);
    }

    private void BakePizza()
    {
        Console.WriteLine("Baking Pizza...");
        Thread.Sleep(4000);
        Console.WriteLine("Pizza ready!");
    }
}

public class DessertSync
{
    public void Serve()
    {
        Console.WriteLine("\nServing Dessert...");
        Thread.Sleep(1000);
        Console.WriteLine("Dessert ready!");
    }
}