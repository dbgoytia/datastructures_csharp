# Arrays

Arrays are one of the most basic examples of a Data structure.

Namespace: System.Arrays

In an Array Data structure, you can store multiple values of the
same type in an Array Data structure. Since C# is OOP, you can either
specify the value of the type the Array is going to hold:

```
int []a1;
```

or you can specify the type **object** to tell the Array to hold anything

```
object []a1;
```

In the unified type system of C#, all types, predefined and user-defined,
inherit directly or indirectly from Object


Arrays can be:
* Single-dimensional
* Multi-dimensional
* Jagged arrays

It is also worth noticing that you can specify the LowerBound for the arrays,
something not very common in other programming langauges. You can for example,
start the first index at 1, instead of starting the first index at 0, by
implementing an instance of Array using the CreateInstance method. I'm not yet
sure of the importance or relevance of doing this other than readability.


All arrays implemenet the IList, IEnumerable interfaces. Single-dimensional arrays
also implement IList<T> and IEnumerable<T>.


## Default behaviour

The array elements are initialized with the default value, 0-bit pattern.


## Differences with other languages

C# Arrays are objects, instead of only addressable regions of contigous
memory, as in C and C++.


## Jagged arrays

Jagged array are an interesting type of Array actually. They can be used to
store rows of data of varying lengths to improve performance when working with
multi-dimensional arrays. For example, in a situation where a lot of your
values in your matrix are 0, probably cutting down all of those values will
give you a noticable speed increase.


In a Jagged array, it's elements are reference types, and are initialized to null.



# Arrays in memory - how are they organized?

Arrays are in the area of C# reference types. As you probably know,
variables of reference types store references to their data (objects), while
variables of the value types directly contain their data
visit [reference types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types)
to learn more about it.


For an example, let's assume we have two arrays, one that contains a **reference type**
[StringBuilder](https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-6.0),
and one that contains a **value type** [int](https://docs.microsoft.com/en-us/dotnet/api/system.int32?view=net-6.0)

```
// Reference type
var builders = new StringBuilder[4];
builders[0] = new StringBuilder("b1");
builders[1] = new StringBuilder("b2");


// Value type
int[] numbers = new int[4];
numbers[0] = 5;
numbers[1] = 7;
numbers[2] = 1;
numbers[3] = 4;
```

In reality, this would look something like this in memory:

```
                    |
   STACK            |    HEAP
                    |
 __________         |    _____ _____ _____ _____
|          |        |   |     |     |     |     |
| builders |--------|-->|     |     | null| null|
|__________|        |   |_____|_____|_____|_____|
                    |      |     |
                    |      v     v
                    |    _____   ____
                    |   |     | |    |
                    |   | b1  | | b2 |
                    |   |_____| |____|
                    |
                    |
 __________         |    _____ _____ _____ _____
|          |        |   |     |     |     |     |
| numbers  |--------|-->|  5  |  7  |  1  |  4  |
|__________|        |   |_____|_____|_____|_____|

```

