# 🚀 C# Concurrency & .NET Deep Dives

Welcome! This repository serves as my personal knowledge hub and code archive as I study asynchronous programming, multithreading, and advanced .NET runtime mechanics. 

It contains practical C# experiments, architectural notes, and step-by-step traces of how the .NET concurrency model works under the hood.

---

## 📌 Key Topics Covered

### 1. Asynchronous Programming (`async` / `await`)
- **State Machine Mechanics:** How `async`/`await` rewrites methods under the hood.
- **`SynchronizationContext`:** Context capturing, UI Thread behavior, and avoiding deadlocks (`.Result` / `.Wait()` pitfalls).
- **Task Best Practices:** Hot vs. Cold tasks, `Task.Delay`, `ConfigureAwait`, and "Async All The Way".

### 2. Multithreading & Runtime Internals
- **Execution Model:** Threads vs. Processes, Instruction Pointers, and Call Stacks.
- **CPU Scheduling:** Cores, ThreadPool management, and context switching overhead.
- **ASP.NET Core vs. UI Contexts:** Why web servers lack `SynchronizationContext` and how thread pool starvation occurs.

### 3. Concurrent & Immutable Collections
- **`System.Collections.Concurrent`:** Thread-safe collections (`ConcurrentDictionary`, `ConcurrentQueue`), lock-free operations, and snapshots.
- **`System.Collections.Immutable`:** Persistent data structures, structural sharing (tree reallocation), and functional paradigms.

---

## 📂 Repository Structure

```text
.
├── 02-Async-Basics/            # Task, ValueTask, progress reporting, exception handling
├── 03-Async-Streams/           # IAsyncEnumerable<T>, LINQ with streams, cancellation
├── 04-Parallel-Basics/         # Parallel.ForEach, Parallel LINQ (PLINQ), aggregation
├── 05-Dataflow-Basics/         # TPL Dataflow blocks, linking, error propagation, throttling
├── 06-System-Reactive-Basics/  # IObservable<T>, events-to-streams, buffering, throttling
├── 07-Testing/                 # Unit testing async methods, Dataflow meshes, Rx schedules
├── 08-Interop/                 # Wrapping legacy APM/EAP patterns, Rx <-> Async conversions
├── 09-Collections/             # Concurrent vs. Immutable collections, blocking & async queues
├── 10-Cancellation/            # CancellationTokenSource, timeouts, cross-paradigm cancellation
├── 11-Functional-Friendly-OOP/ # Async initialization, factories, properties, disposal
├── 12-Synchronization/         # Async Locks (SemaphoreSlim), signals, throttling
├── 13-Scheduling/              # ThreadPool scheduling, custom TaskSchedulers
└── 14-Scenarios/               # Async lazy initialization, data binding, railway programming
