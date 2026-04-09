using CareerCompassWorkshop.Orders;

namespace CareerCompassWorkshop.Restaurant;

public class RestaurantSync
{
    public void Open()
    {
        Console.WriteLine("\nRestaurant opened!");
    }

    public void Work()
    {
        var person1 = new Person1Sync();
        var person2 = new Person2Sync();

        person1.Order();        
        person2.Order();

        person1.Prepare();
        person2.Prepare();

        person1.Serve();
        person2.Serve();

        var dessert = new DessertSync();
        dessert.Serve();
    }

    public void Close()
    {
        Console.WriteLine("\nRestaurant closed!");
    }
}
