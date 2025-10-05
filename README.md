# HashingOutCollections (main branch)

PROG3B — ICE Task 2 (C# Console App)

This branch contains a **menu-driven** console app with the practical tasks split into **three files** for clarity:

* `Program.cs` → main menu & navigation
* `Task1.cs` → Task 1 (Dictionary: StudentID → Name)
* `Task2.cs` → Task 2 (HashSet: Unique Course Codes)
* `Task3.cs` → Task 3 (Set Ops: Intersection, Difference, Union)

> Note: The assignment labels vary between the brief and code comments. Here, we align the file names to the three practical parts delivered in class.

---

## 📦 What this app demonstrates

* **Task 1 — Dictionary (StudentID → Name)**

  * Builds and prints a `Dictionary<string,string>` for five students.
  * Shows safe add with `TryAdd`, indexer overwrite, and `TryGetValue` lookup.

* **Task 2 — HashSet (Unique Course Codes)**

  * Builds a `HashSet<string>` of course codes using `StringComparer.OrdinalIgnoreCase`.
  * Demonstrates automatic de‑duplication and `Add` returning `false` on duplicates.

* **Task 3 — Set Operations (Math vs Science)**

  * Creates two sets of names and prints:

    * **Intersection** → students in **both** classes
    * **Difference** → students **only** in Math
    * **Union** → **all** unique students

---

## 🗂️ Project structure

```
HashingOutCollections/
├─ Program.cs         # menu + navigation only
├─ Task1.cs           # Dictionary demo (students)
├─ Task2.cs           # HashSet demo (course codes)
├─ Task3.cs           # Set operations (Math vs Science)
├─ HashingOutCollections.csproj
└─ README.md          # this file
```

---

## ✅ Requirements

* .NET SDK **8.0+** (works on 9.0 too)
* VS Code / Visual Studio / Rider

Check SDK:

```bash
dotnet --info
```

---

## 🚀 Build & Run

### .NET CLI

```bash
# from repo root
dotnet build
dotnet run
```

You will see a **MAIN MENU**. Choose:

* `1` → Task 1 (Dictionary)
* `2` → Task 2 (HashSet)
* `3` → Task 3 (Set operations)
* `0` → Exit

### Visual Studio Code

1. Open the folder.
2. If prompted, **Add required assets**.
3. Press **F5** to run/debug, or run `dotnet run` in the terminal.

### Visual Studio

1. Open the solution/project.
2. Set project as **Startup Project**.
3. **F5** to run.

---

## 🧠 Key concepts (quick notes)

* **Dictionary<TKey,TValue>** → unique keys, fast key lookups (~O(1)).
* **HashSet<T>** → unique elements, fast membership checks (~O(1)).
* **Set operations** → `IntersectWith`, `ExceptWith`, `UnionWith` for common, only‑in‑A, and all‑unique elements respectively.

---

## ✍️ How to modify

* Edit IDs/names in `Task1.cs`.
* Add/remove course codes in `Task2.cs` (duplicates will be ignored).
* Change Math/Science rosters in `Task3.cs` to test other combinations.

---

