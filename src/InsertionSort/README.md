Insertion Sort
===============


Imagine when you sort cards when you sort cards in your hand (that's how
you can imagine this). Basically:

* Imagine you have a sepparator, in the leftside you assume everything is sorted
* On the rightside of the sepparator, you pickup cards that are lower than the
right-most element in your left-side elements
* For that lower element, you swap elements until you find the appropiate spot
for the element in the left-side array.


### Initial scenario:

For this sorting algorith we also need a wall, that will start at position 1.
We consider every element in the left of the wall to be sorted. For example,
on the first run, the wall is going to be at 1. All elemnents in the left
are: [10], so we can consider (obviously) that this array is sorted:



```

# Initial scenario:

    0       1       2       3       4
 ---------------------------------------
|   10  |   8   |   14  |   5   |   12  |
 ---------------------------------------
    |      |
    i     wall

```

### First run:


We have to iterate until we find the element that's lower than the element at
wall - 1. In there, we should perform the insertion.

In this case, we find that 8 is less than 10, so we save 8 to a sepparate var,
and insert it in the correct position in the left array, which is always going
to be at the very beginning of the array.


```

# First run:

    0       1       2       3       4
 ---------------------------------------
|   10  |   8   |   14  |   5   |   12  |
 ---------------------------------------
    |      |
    i     wall


# since 8 < 10, swap(8, 10):



    0       1       2       3       4
 ---------------------------------------
|   8  |   10   |   14  |   5   |   12  |
 ---------------------------------------
    |      |
    i     wall



# and increment wall (or part index)


    0       1       2       3       4
 ---------------------------------------
|   8  |   10   |   14  |   5   |   12  |
 ---------------------------------------
    |               |
    i              wall



```


### Second run:


On the next run, the **current unsorted** value is going to be 14. In this point
we see that the current unsorted, is larget than the element at wall - 1, so we
don't need to sort it.


```

# Second run


    0       1       2       3       4
 ---------------------------------------
|   8  |   10   |   14  |   5   |   12  |
 ---------------------------------------
    |               |
    i              wall


# Current unsorted (14) is greater than array[wall - 1], so just move wall (no sort)



    0       1       2       3       4
 ---------------------------------------
|   8  |   10   |   14  |   5   |   12  |
 ---------------------------------------
    |                       |
    i                      wall



```


### Third run:


On the next run, 5 is less than 14, so we can save it in a sepparate value
**current unsorted**. This is a good example that you can see that you need
to swap until you find the appropiate spot for the element.


```

# Third run



    0       1       2       3       4
 ---------------------------------------
|   8  |   10   |   14  |   5   |   12  |
 ---------------------------------------
    |                       |
    i                      wall

currentlyUnsorted = 5


# Swap until we find correct position


# 5 < 14 ? True : Swap : DoNothing

    0       1       2       3       4
 ---------------------------------------
|   8  |   10   |   5  |   14   |   12  |
 ---------------------------------------
    |                       |
    i                      wall


# 5 < 10 ? True : Swap : DoNothing

    0       1       2       3       4
 ---------------------------------------
|   8  |   5   |   10  |   14   |   12  |
 ---------------------------------------
    |                       |
    i                      wall


# 5 < 8 ? True : Swap : DoNothing

    0       1       2       3       4
 ---------------------------------------
|   5  |   8   |   10  |   14   |   12  |
 ---------------------------------------
    |                       |
    i                      wall


# Reached begining of the array, so we move wall one step

    0       1       2       3       4
 ---------------------------------------
|   5  |   8   |   10  |   14   |   12  |
 ---------------------------------------
    |                               |
    i                              wall


```

### Fourth run:


In the last run, the currently unsorted element is 12, and since 12
is less than 14 (wall -1), we can start swapping until we find the appropiate
space for the element.


```

# Fourth Run


    0       1       2       3       4
 ---------------------------------------
|   5  |   8   |   10  |   14   |   12  |
 ---------------------------------------
    |                               |
    i                              wall


currentlyUnsorted = 12


# Swap until we find correct position

# 12 < 14 ? True : Swap : DoNothing

    0       1       2       3       4
 ---------------------------------------
|   5  |   8   |   10  |   12   |   14  |
 ---------------------------------------
    |                               |
    i                              wall


# 12 < 10 ? True : Swap : DoNothing

# And we have found the correct space for the currentlyUnsorted element.


# Since wall == length(array), finish sorting.

```