# Stack & Heap — Order Class

The following diagrams show what happens when an `Order` class object is created, copied, and modified.

## Diagram 1 — After line 1

```text
Order o1 = new Order { OrderId = 1, CustomerName = "Ali" };

+-------------------+       +-----------------------------+
|       STACK       |       |            HEAP            |
+-------------------+       +-----------------------------+
|                   |       |                             |
| o1                |------>| Address: 0x100              |
| 0x100             |       |                             |
|                   |       | Order                       |
|                   |       | -------------------------   |
|                   |       | OrderId      = 1            |
|                   |       | CustomerName = "Ali"        |
|                   |       | IsPaid       = false        |
|                   |       |                             |
+-------------------+       +-----------------------------+
```

`o1` is a reference stored on the stack, pointing to an `Order` object stored on the heap.

---

## Diagram 2 — After line 2

```text
Order o2 = o1;

+-------------------+       +-----------------------------+
|       STACK       |       |            HEAP            |
+-------------------+       +-----------------------------+
|                   |       |                             |
| o1                |------>| Address: 0x100              |
| 0x100             |   |   |                             |
|                   |   |   | Order                       |
| o2                |---|-->| -------------------------   |
| 0x100             |       | OrderId      = 1            |
|                   |       | CustomerName = "Ali"        |
|                   |       | IsPaid       = false        |
|                   |       |                             |
+-------------------+       +-----------------------------+
```

`o2` receives the same reference as `o1`, so both variables point to the **same heap object**.

---

## Diagram 3 — After line 3

```text
o2.IsPaid = true;

+-------------------+       +-----------------------------+
|       STACK       |       |            HEAP            |
+-------------------+       +-----------------------------+
|                   |       |                             |
| o1                |------>| Address: 0x100              |
| 0x100             |   |   |                             |
|                   |   |   | Order                       |
| o2                |---|-->| -------------------------   |
| 0x100             |       | OrderId      = 1            |
|                   |       | CustomerName = "Ali"        |
|                   |       | IsPaid       = true         |
|                   |       |                             |
+-------------------+       +-----------------------------+
```

`o2.IsPaid = true` changes the single shared heap object, so the change is visible through both `o1` and `o2`.

---

## What would be different with structs?

If `Order` were a `struct` instead of a `class`, assigning `o2 = o1` would create a **copy of the value** rather than another reference to the same heap object.

For example, with the `Point` struct from Part C:

```csharp
Point p1 = new Point { X = 1, Y = 2 };
Point p2 = p1;

p2.X = 100;
```

`p1` and `p2` would contain separate copies:

```text
STACK

+-------------------+
| p1                |
| X = 1             |
| Y = 2             |
+-------------------+

+-------------------+
| p2                |
| X = 100           |
| Y = 2             |
+-------------------+
```

Changing `p2.X` would **not change `p1.X`**, because structs have value-type copy semantics.
