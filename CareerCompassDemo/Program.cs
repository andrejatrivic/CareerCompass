using System.Diagnostics;
using CareerCompassDemo.Async;
using CareerCompassDemo.Sync;

var sw = Stopwatch.StartNew();

// Sync example

Console.WriteLine("---- SYNC ----");

var syncExample = new SyncExample();
syncExample.RunSync();

Console.WriteLine($"Total time: {sw.ElapsedMilliseconds} ms.\n");

sw.Restart();

// Async example

Console.WriteLine("---- ASYNC ----");

var asyncExample = new AsyncExample();
await asyncExample.RunAsync();

Console.WriteLine($"Total time: {sw.ElapsedMilliseconds} ms.\n");

sw.Restart();

// Async 2 example

Console.WriteLine("---- ASYNC 2 ----");

var async2Example = new Async2Example();
await async2Example.RunAsync();

Console.WriteLine($"Total time: {sw.ElapsedMilliseconds} ms.\n");