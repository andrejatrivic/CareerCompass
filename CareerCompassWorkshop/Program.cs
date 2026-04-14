using System.Diagnostics;
using CareerCompassWorkshop.Restaurant;

var sw = Stopwatch.StartNew();

#region SYNC

Console.WriteLine("---- SYNC ----");

var restaurantSync = new RestaurantSync();

restaurantSync.Open();
restaurantSync.Work();
restaurantSync.Close();

Console.WriteLine($"Total sync working time: {sw.ElapsedMilliseconds} ms.\n");

#endregion

sw.Restart();

#region ASYNC

Console.WriteLine("---- ASYNC ----");

var restaurantAsync = new RestaurantAsync();

restaurantAsync.Open();
await restaurantAsync.WorkAsync();
restaurantAsync.Close();

Console.WriteLine($"Total async working time: {sw.ElapsedMilliseconds} ms.\n");

#endregion