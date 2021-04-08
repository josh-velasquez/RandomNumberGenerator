# Random List Generator
Random list generator that when given a list, randomizes the position of the elements in that list.

## Exposed functions
* List<int> GenerateIntegerList(int min, int max)  
    * Generate a list of integers from min to max (incremented by 1)
* List<T> GenerateRandomList(List<T> list, RandomAlgorithm algorithm)
    * Generates a random list from the list given using the random algorithm specified. If no algorithm is specified, the program defaults to using the modified Fisher-Yates shuffle

## Algorithms
The program can be used to randomize any type of object list. To randomize their elements' position, various algorithms can be used or implemented.

### Modified Fisher-Yates Shuffle
[Fisher-Yates Shuffle](https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle)
Runtime: O(n)  
Algorithm: for each element in the list, generate a random number between 0 and the index of that element. Once you have the random value, swap the position of the current element with the element at the index of the random number.