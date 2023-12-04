# Day 3
Input: a grid which contains numbers, dots, and symbols

Part 1: Provide the sum of all numbers adjacent to a symbol

Algorithm for finding this is like:

1. Find where the symbols are in the grid
2. Find the numbers adjacent to the symbol
3. Add the numbers

The hashset is an excellent tool here, since we can use it to prevent "double counting" of numbers.

Optimization: steps 1 and 2 could be done at the same time, but I just iterate through the grid twice. For the 140 x 140 grid, it's quick enough.

Warning: this code WILL break if there are symbols on the edge of the grid, as it does not perform that error check.

Part 2: Similar to part 1, but only account for "gears", and only if they have exactly two adjacent numbers

Very similar. I ended up using a dict of hash sets to keep track of which numbers were associated to each gear. I had planned on using a GridNumber class to keep track of numbers, but realized I could do with built in data structures instead.

Same optimization note. Same warning.
