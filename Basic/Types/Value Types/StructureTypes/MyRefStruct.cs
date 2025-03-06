
/*
 * allocated on the stack,
 *
 */
ref struct MyRefStruct(int value)
{
   public int Value = value;
}

/*
In C#, **ref structure types** (`ref struct`) are stack-allocated structures that cannot be used on the heap. They are designed for high-performance scenarios where avoiding garbage collection and heap allocations is critical. Here’s a summary of their key characteristics:

### **Key Features of `ref struct`**
1. **Stack Allocation**:  
   - `ref struct` instances are allocated on the stack, making them efficient and avoiding garbage collection overhead.
   
2. **Restricted Usage**:  
   - Cannot be boxed (i.e., converted to `object` or an interface).
   - Cannot be used as a field in a class or another `ref struct`.
   - Cannot be stored in heap-allocated objects like arrays, fields of classes, or captured in lambdas.
   
3. **Use Cases**:  
   - Often used in performance-critical scenarios, such as **Span<T>** and **ReadOnlySpan<T>**, which enable efficient memory access without heap allocation.
   - Useful in scenarios where **deterministic disposal** of resources is needed.

4. **Limitations**:  
   - Cannot implement interfaces.
   - Cannot be used in asynchronous methods (except when passed by reference to a synchronous method).
   - Cannot be used in iterators (`yield return`).
   
### **When to Use `ref struct`?**
- When working with **large structures** that should not be allocated on the heap.
- When using **Span<T>** or other stack-based data types to optimize memory and performance.
- When ensuring **strict memory safety** by preventing heap allocations.

Would you like a deeper dive into any specific aspect? 🚀

*/