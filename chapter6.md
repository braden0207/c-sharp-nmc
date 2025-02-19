### Summary of Lists and ArrayLists in C#  

#### **Creating a List**  
A list is created using the `List<Type>` syntax, where `<Type>` represents the data type. The initializer list `{}` is optional but required in syntax.  
**Examples:**  
```csharp
List<int> scores = new List<int> {};  
List<string> members = new List<string> {};  
```

#### **Adding Data to a List**  
Data can be added using:  
- **Initializer List** (when declaring the list)  
- **`Add()` Method** (adds single elements)  
- **`Insert()` Method** (adds elements at a specific index)  

#### **ArrayList vs List**  
- **ArrayList** works similarly to `List<>`, but it is not strongly typed, meaning it can store different data types.  
- **Example:**  
  ```csharp
  string tempName = "First Quarter";  
  double begBalance = 5000.00;  
  ArrayList account = new ArrayList() { tempName, begBalance };  
  ```

#### **Using `var` Data Type**  
- `var` allows dynamic data type assignment based on the assigned value.  
- **Example:**  
  ```csharp
  var comment = "I love programming";  
  var score = 100;  
  ```
- **Rules:**  
  - Must be initialized when declared.  
  - Cannot be used in method parameters or return types.  

#### **Sorting, Counting, and Retrieving Data**  
- **Sorting:** Possible only if all elements have the same data type.  
- **Counting:** `Count()` method retrieves the total number of elements.  
- **Retrieval:** Uses `for` or `foreach` loops.  

#### **Removing Items from an ArrayList**  
Four methods:  
- `Remove()` – Removes a specific item.  
- `RemoveAt(index)` – Removes an item at a specific index.  
- `RemoveRange(start, count)` – Removes multiple items.  
- `Clear()` – Removes all items.  

For further examples, refer to **Programming Example 3: ArrayList (Chapter 6 Lab Assignments).**
