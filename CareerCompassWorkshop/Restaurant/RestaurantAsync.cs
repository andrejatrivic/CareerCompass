namespace CareerCompassWorkshop.Restaurant;

public class RestaurantAsync
{
    public void Open()
    {
        Console.WriteLine("Restaurant opened! \n");
    }

    public async Task Work()
    {
        // TODO:
        // Two customers walk in together and order food at the same time.
        // 1. Person 1 orders a burger and fries.
        //    - Burger and fries are independent and can be cooked concurrently.
        // 2. Person 2 orders a pizza.
        //    - Pizza must be prepared in sequence: dough -> sauce -> cheese -> bake.
        // 3. Serve both meals together after all items are ready.
        //    - You may need to wait for multiple tasks to complete before serving.
        // 4. Prepare and serve dessert after main meals.
        //    - This should start after all main courses finish.
    }

    public void Close()
    {
        Console.WriteLine("Restaurant closed! \n");
    }
}
