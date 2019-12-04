When creating a variable of a class, i.e.
var student = new Student();

you can assign student to null,
student = null;

at this point the object is just floating around. not being referenced to any variable any longer, meanig its completely useless to the program. When an object enters this useless state, it needs to get thrown out or "garbage collected".


because student is an instance 'reference type'. 

int can be: 
int x = 1;
int x = 0;
int x; 

CANNOT be: 
int x = null;

This is because an int is a value type. When we create a variable for an object, i.e. Student(), we are creating a reference type.


The type of a variable needed to hold an object is a reference type.
Type type of a variable needed to hold an it is a value type.

When an object is created, its created in memory and needs a reference type variable to point to that memory location. The variable points to the object in memory, but doesn't actually contain that object.

Whenever we use the new keyword, we are using some memory to create or instantiate that object. When a variable no longer points to that object, the object becomes useless since it can never be accessed again. i.e. lost inside a black hole. If we end up doing this many times, our program uses much more memory than it actually needs. Sometimes called a 'memory leak'.

The .net garbage collector checks for all objects that don't have references and deletes them. 