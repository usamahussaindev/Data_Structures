### LinkedList<T>

A `LinkedList<T>` is a data structure in C# that represents a doubly linked list. It allows for efficient insertions and deletions at both ends of the list but has slower random access compared to arrays or lists. Here are some key points about `LinkedList`:

- **Doubly Linked List:** A linked list is made up of nodes, and each node contains two references: one to the previous node and one to the next node. This structure allows for easy traversal in both directions.

- **Dynamic Sizing:** A `LinkedList` can dynamically grow or shrink as elements are added or removed.

- **Insertions and Deletions:** Insertions and deletions in a `LinkedList` are generally faster than in an array or list because they involve changing a few references, rather than shifting elements.

- **Slower Random Access:** Unlike arrays or lists, accessing elements by index in a `LinkedList` is slower because you need to traverse the list from the beginning or end to reach the desired element.

- **Example Usage:**

  ```csharp
  LinkedList<string> linkedList = new LinkedList<string>();
  linkedList.AddLast("A");
  linkedList.AddLast("B");
  linkedList.AddLast("C");
  // Resulting list: A -> B -> C
  ```

### HashSet<T>

A `HashSet<T>` is a collection in C# that stores unique elements. It ensures that duplicates are not allowed. Here are some key points about `HashSet`:

- **Uniqueness:** A `HashSet` only allows unique elements, meaning that duplicate values will be automatically ignored.

- **Fast Lookups:** HashSet offers constant-time average performance for basic operations like adding, removing, and checking for the existence of an element.

- **No Guaranteed Order:** Elements in a `HashSet` are not stored in any specific order. They are organized internally for efficient lookups.

- **Example Usage:**

  ```csharp
  HashSet<int> uniqueNumbers = new HashSet<int>();
  uniqueNumbers.Add(1);
  uniqueNumbers.Add(2);
  uniqueNumbers.Add(1); // Ignored, as it's a duplicate
  // Resulting set: {1, 2}
  ```

### SortedSet<T>

A `SortedSet<T>` is similar to a `HashSet`, but it keeps elements sorted either in their natural order (e.g., ascending for integers) or using a custom comparer. Here are some key points about `SortedSet`:

- **Sorted Order:** Elements in a `SortedSet` are always maintained in a sorted order, making it useful for scenarios where you need elements sorted automatically.

- **Efficient for Sorted Operations:** Operations like finding the minimum or maximum element are efficient in a `SortedSet`.

- **Custom Sorting:** You can specify a custom comparer to define how elements should be sorted.

- **Example Usage:**

  ```csharp
  SortedSet<int> sortedNumbers = new SortedSet<int>();
  sortedNumbers.Add(3);
  sortedNumbers.Add(1);
  sortedNumbers.Add(2);
  // Resulting set: {1, 2, 3}
  ```

### BitArray

A `BitArray` is a data structure in C# that represents a collection of boolean values as bits. It is useful for working with binary data or efficiently storing and manipulating a large number of boolean values. Here are some key points about `BitArray`:

- **Space Efficiency:** `BitArray` uses a compact representation of boolean values, using one bit per boolean.

- **Bit Manipulation:** It provides methods for setting, clearing, and testing individual bits.

- **Use Cases:** `BitArray` is often used in scenarios where you need to perform bitwise operations or compactly store boolean flags.

- **Example Usage:**

  ```csharp
  BitArray bits = new BitArray(32); // Creates a BitArray with 32 bits
  bits.Set(3, true); // Sets the 3rd bit to true
  bool isSet = bits[3]; // Retrieves the value of the 3rd bit (true)
  ```
