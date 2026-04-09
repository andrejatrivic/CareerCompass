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
