using CareerCompassWorkshopSolution.Orders;

namespace CareerCompassWorkshopSolution.Restaurant;

public class RestaurantAsync
{
    public void Open()
    {
        Console.WriteLine("Restaurant opened! \n");
    }

    public async Task WorkAsync()
    {
        var person1 = new Person1Async();
        var person2 = new Person2Async();

        var person1Order = person1.OrderAsync();
        var person2Order = person2.OrderAsync();
        await Task.WhenAll(person1Order, person2Order);

        var person1Prepare = person1.PrepareAsync();    
        var person2Prepare = person2.PrepareAsync();
        await Task.WhenAll(person1Prepare, person2Prepare);

        var person1Serve = person1.ServeAsync();
        var person2Serve = person2.ServeAsync();
        await Task.WhenAll(person1Serve, person2Serve);

        var dessert = new DessertAsync();
        await dessert.ServeAsync();
    }

    public void Close()
    {
        Console.WriteLine("Restaurant closed! \n");
    }
}
