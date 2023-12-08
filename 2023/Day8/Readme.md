# Day 8

Input: A list of locations and the next location based on if you go left or right and a sequence of left and right choices to make

Part 1: Find the number of moves you need to make by following the sequence of left and right moves from location AAA to ZZZ

Just follow the path. The problem is that this part sets you up for failure if you take a niave approach for part 2.

Part 2: There are six locations that end with the letter A, and six locations that end with the letter Z. Find in how many moves all of the A locations go to all of the Z locations

If you just follow the path as in the first part, it will take a long time to find the answer. The first path took ~10^4 moves, so six paths aligning might take (10^24) operations, or one trillion trillion.

This is the first day I didn't see an obivous solution to, which is fun!

Taking a look at the dataset, there are 271 spots in the path you can be, and 1000 locations you can be at. 
Therefore, there are <271,000 possible "states" for the problem. 
From each of these states, we can calculate how many steps it takes to reach the next Z state, and which Z state that is.
Based on part 1, that's a problem on the order of 10^5 * 10^4, or 10^9. 
One billion operations is much more reasonable for my computer to perform.

