# HashTables in C#
 Hashtables in C#

# Definition
Hashtable are key value Look ups - Just like Dictionaries
Purpose is to get O(1) or constant time complexity
 * You can also choose to use a Balanced Binary Search Tree for O(log n) which is also constant time complexity

 Hashtables are good for large data sets;

 Worst case scenario with extreme collisions +> time complexity becomes O(n) or linear time complexity

 The Goal is to understand that their could be infinite hashkeys but can be fit into a finite number of array indexes.

 (key , value)

Key could be any data type and so can the value

When there is a collision at a particular index we, create a linked list to chain the values to one another at the particular index.

# FlowChart
* Hashingtable(key, value) -> hashingfunction -> insert@LinkedList Array Index -> add value to object at index

Helper methods like Printhashingtable help print the entire hashtable.
Helper methods like get help search the entire hashtable.

* (key will be the name)
* (value will be the phonenumber in my case)


