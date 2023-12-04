# Day 1
Input: a list of strings that contain digits 0,1,2...9 and the written forms of numbers (one, two, three...)

Part 1: The first and last digit in the string become a two digit number. Add all of these values for each line together.

I used a regex for this to find the first and last digit.

Part 2: Same as part 1, but we also need to account for the written forms of numbers.

Modifying the regex to include the written numbers almost works, but breaks for cases like eightwo.

Instead, I run the regex twice, once forwards and once backwards to get the numbers.

Code only contains part 2 solution
