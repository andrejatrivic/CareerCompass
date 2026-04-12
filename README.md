# FOI Career Compass Workshop

This workshop demonstrates the differences between:

- Synchronous programming
- Asynchronous programming (sequential)
- Asynchronous programming with concurrency (`Task.WhenAll`)

## 1. Synchronous Programming

Synchronous programming, tasks are executed **one after another**. Each task blocks the thread until it is completed.

## 2. Asynchronous Programming (Sequential)

Asynchronous code allows non-blocking execution, but tasks can still run one after another.

## 3. Asynchronous Programming with Task.WhenAll (Concurrent)

Tasks can run at the same time when they are independent.

## Summary

| Feature  | Sync | Async Sequential | Async Concurrent |
| - | - | - | - |
| Execution | Blocking | Non-blocking | Non-blocking |
| Order | Sequential | Sequential | Concurrent |
| Total time | Sum | Sum | Max |

## Exercise

Two customers walk in together and order food at the same time.
1. Person 1 orders a burger and fries. (Burger and fries are independent and can be cooked concurrently.)

2. Person 2 orders a pizza. (Pizza must be prepared in sequence: dough -> sauce -> cheese -> bake.)

3. Serve both meals together after all items are ready. (You may need to wait for multiple tasks to complete before serving.)

4. Prepare and serve dessert after main meals. (This should start after all main courses finish.)
