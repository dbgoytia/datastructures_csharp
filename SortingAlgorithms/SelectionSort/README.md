Selection Sort
===============

Similar to bubble sort, it will also have a wall and an iterator.
What we're basically doing is find the greatest element in the array,
and save it in the last index.


```
# pseudocode

selection_sort(arr):

    if len(arr) == 0:
        return ValueError("we should at least have one element on the array")

    if len(arr) < 1:
        return arr      # already sorted
        

    greatest = arr[0]           # in the first pass the first one is always the greatest
    index = 1                   # consider the next one as the starting point
    wall  = len(arr) - 1        # cut array in two


    while wall > 0:

        # find the greatest until wall
        while i <= wall:
            if arr[i] > greatest:
                greatest = arr[i]
            i ++

        # swap greatest with wall
        swap(greatest, arr[wall])

        # retroceede the wall one step
        wall --
    

```

Caracteristics
==============

* In-place algorithm: uses a small amount of extra memory.

* Unstable: Could be that swapping happens on two equal elements.

* O(n^2) time complexity **quadratic**

* Degrades quickly (though, it's usually faster than bubble sort.)
    


Sample run
=============


If you want to see it in action, it kind of looks like this:

```

1.-

[10, 8, 14, 5, 12] 
     i          w

i <= w:
    greatest = 10
    i > greatest ?: false

2.-
[10, 8, 14, 5, 12] 
         i      w
 
i <= w:
    greatest = 10
    i > greatest ?: true
    then greatest = 14


3.-
[10, 8, 14, 5, 12] 
            i   w

i <= w:
    greatest = 14
    i > greatest ? false


3.-
[10, 8, 14, 5, 12] 
              i = w

i <= w:
    greatest = 14
    i > greatest ? false


4.-
[10, 8, 14, 5, 12] 
                w  i 
i <= w: False
swap(greatest, w) ---> [10, 8, 12, 5  |  14]
w = w -1

...

And so on.


```
