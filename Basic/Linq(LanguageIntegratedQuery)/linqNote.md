Here's a comprehensive list of LINQ **method syntax** extension methods in C#. These methods are typically available via `System.Linq` and can be chained using dot notation (method chaining).

---

### **LINQ Query Operators (Method Syntax)**

#### **1. Filtering**

* `Where`
* `OfType`

#### **2. Projection**

* `Select`
* `SelectMany`

#### **3. Sorting**

* `OrderBy`
* `OrderByDescending`
* `ThenBy`
* `ThenByDescending`
* `Reverse`

#### **4. Grouping**

* `GroupBy`
* `ToLookup`

#### **5. Joining**

* `Join`
* `GroupJoin`

#### **6. Set operations**

* `Distinct`
* `Union`
* `Intersect`
* `Except`

#### **7. Element operators**

* `First`
* `FirstOrDefault`
* `Last`
* `LastOrDefault`
* `Single`
* `SingleOrDefault`
* `ElementAt`
* `ElementAtOrDefault`
* `DefaultIfEmpty`

#### **8. Quantifiers**

* `Any`
* `All`
* `Contains`

#### **9. Aggregation**

* `Count`
* `LongCount`
* `Sum`
* `Min`
* `Max`
* `Average`
* `Aggregate`

#### **10. Conversion**

* `ToList`
* `ToArray`
* `ToDictionary`
* `ToLookup`
* `AsEnumerable`
* `AsQueryable`

#### **11. Generation**

* `Empty<T>()`
* `Range`
* `Repeat`

#### **12. Concatenation**

* `Concat`
* `Append`
* `Prepend`

#### **13. Partitioning**

* `Take`
* `TakeWhile`
* `Skip`
* `SkipWhile`

#### **14. Equality**

* `SequenceEqual`

#### **15. Zipping**

* `Zip`

#### **16. Miscellaneous**

* `Cast`
* `Let` (used only in query syntax)
* `GroupBy(...).Select(...)` (common for aggregating results in method syntax)

---

### **Example (Method Syntax)**

```csharp
var result = people
    .Where(p => p.Age > 18)
    .OrderBy(p => p.Name)
    .Select(p => new { p.Name, p.Age })
    .ToList();
```

Let me know if you want categorized examples of each one.
