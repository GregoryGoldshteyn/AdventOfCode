# Day 7

Input: A list of poker hands and wagers

Part 1: Based on a provided ruleset, calculate the value of each hand based on its contents and the amount betted on

This variation of poker is more like video poker than Texas Hold em. Again the sortedSet helps when applied with a comparer that can compare the "values" of the hands.

A bit overengineered, but it was easy to extend the solution for part 2, because the logic is more or less the same with a slight change in how the value of a hand is calculated.

Part 2: Jacks are wildcards that can be applied to make the best hand possible

A little extra logic to account for the number of jacks while evaluating a hand is all that is required to solve this.