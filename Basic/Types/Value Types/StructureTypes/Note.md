
 1) Value Type: Stored on the stack (except when inside a reference type).

 2) Lightweight: Less memory overhead compared to classes.

 3) No Inheritance: Cannot inherit from or be inherited by other types.

 4) Can Implement Interfaces: Structs can implement interfaces but not inherit 
    from other structs or classes.

 5) Implicit Parameterless Constructor: Cannot define an explicit parameterless 
    constructor; C# initializes fields automatically.

 6) Readonly Structs: Prevents modification of struct instances after initialization.

 7) Ref Structs: Restricts storage of structs to the stack for performance reasons.
   
 8) Value Parsing: When passing structs to methods, they are passed by value, 
    meaning a copy is made.

    

