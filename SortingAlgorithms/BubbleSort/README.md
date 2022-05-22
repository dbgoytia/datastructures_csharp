BubbleSort
===========


* In-place algorithm:
    * uses a small amount of extra memory (doesn't depend on n).
    * This made it relevant for systems that had very little available memory,
    a problem that is no longer present in systems today.

* Stable:
    * Doesn't change the order of the duplicate items.

* Running complexity is (O)n^2 (quadratic).
    * This means that the algorithm degrades really fast.
    * However, the inner loop actually decreases as the algorithm progresses,
      so (O)n^2 is a very rough estimation of the actual performance of the algorithm.