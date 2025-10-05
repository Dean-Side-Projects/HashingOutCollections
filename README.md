# HashingOutCollections

PROG3B — ICE Task 2 (C# Console App)
**One-file solution (`Program.cs`)** that demonstrates Dictionaries and Sets with clear outputs.

---

## 📦 What this app does

This console app completes the **Practical** portion of ICE Task 2:

* **Task 1 — Dictionary (StudentID → Name)**
  Builds a `Dictionary<string,string>` of 5 students and prints the mapping.

* **Task 3 — HashSet (Unique Course Codes)**
  Builds a `HashSet<string>` of course codes and demonstrates **automatic de-duplication**.

* **Task 4 — Set Operations (Math vs Science classes)**
  Creates two student sets and prints:

  * **Intersection** → Students in **both** classes
  * **Difference** → Students **only** in Math
  * **Union** → **All** unique students across both classes

All three tasks run in a single pass when you launch the app.

---

## ✅ Requirements

* .NET SDK **8.0+** (works on 9.0 too)
* Any editor (VS Code / Visual Studio / Rider)
* Terminal access to run `dotnet` commands

Check your SDK:

```bash
dotnet --info
```

---

## 🚀 How to build & run

### Option A: .NET CLI (cross-platform)

```bash
# from the repository root
dotnet build
dotnet run
```

### Option B: Visual Studio Code

1. Open the folder in VS Code.
2. If prompted, **Add required assets** for build & debug.
3. Press **F5** (Run/Debug) or run:

   ```bash
   dotnet run
   ```

### Option C: Visual Studio (Windows)

1. Open the `.sln` or `.csproj`.
2. Set the project as **Startup Project**.
3. Press **F5** to run.

---

## 🗂️ Project structure (simple branch)

```
HashingOutCollections/
├─ Program.cs        # single-file app with all tasks
├─ README.md         # this file
├─ HashingOutCollections.csproj
└─ bin/ obj/         # build outputs (auto-generated)
```

> On your `simple-answer` branch, everything is implemented in **`Program.cs`** for easy marking.

---

## 🧠 Concepts covered (quick notes)

* **Dictionary<TKey,TValue>**

  * Unique keys; values can repeat.
  * ~O(1) average lookups and inserts by key.
* **HashSet<T>**

  * Stores **unique** elements only (no duplicates).
  * Fast membership checks (`Contains`) and inserts (~O(1)).
* **Set operations**

  * `IntersectWith` → common elements
  * `ExceptWith` → elements in A not in B
  * `UnionWith` → all unique elements from both sets

---

## 🖨️ Expected output (sample)

```
ICE Task 2 – Practical (Dictionaries & Sets)
============================================

Task 1: Dictionary of Student IDs → Names
-----------------------------------------
Student ID  →  Name
------------------------------------
ST1001     →  Alice Mthembu
ST1002     →  Bongani Nkosi
ST1003     →  Chloe Daniels
ST1004     →  Devan Pillay
ST1005     →  Esi Okoye

Task 3: HashSet of Unique Course Codes
--------------------------------------
Course Codes (count=5)
---------------------------
• PROG7311
• PROG7312
• INSY6212
• IRIT7311
• MATH3000

Task 4: Set Operations – Math vs Science
----------------------------------------
Math Class (count=5)
---------------------------
• Alice
• Bongani
• Chloe
• Devan
• Esi

Science Class (count=4)
---------------------------
• Chloe
• Esi
• Farah
• Gareth

Both Classes (Intersection) (count=2)
---------------------------
• Chloe
• Esi

Only in Math (Difference) (count=3)
---------------------------
• Alice
• Bongani
• Devan

All Students (Union) (count=7)
---------------------------
• Alice
• Bongani
• Chloe
• Devan
• Esi
• Farah
• Gareth
```

> Counts may appear in a different order because sets/dictionaries don’t guarantee a sort order.

---

## ✍️ How to modify

* Change student IDs/names in the `Dictionary` initialization.
* Add/remove course codes in the `HashSet` (duplicates will be ignored).
* Edit the `Math` / `Science` name lists to test set operations.

---

