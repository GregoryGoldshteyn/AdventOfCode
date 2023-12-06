# Day 4
Input: a list of scratchoff lottery cards' winning numbers and the player's numbers

Part 1: When a winning number and player number match, a card is worth one point. For each subsequent match between the winning number and player numbers, the point value of a card doubles. Find the total value of all cards

The number of matches found is a brute-force solution that is slow, but for the size of the data is fine. Better solution would be to store player numbers in a hashset and look them up instead of storing as list.

Score is given by `floor(pow(2, matches - 1))`.

Part 2: Similar to part 1, but each card wins additional cards of the next cards in the list equal to the score

Added a list containing the count of the cards and incremented based on wins and which card was winning.
