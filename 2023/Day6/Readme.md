# Day 6

Input: A list of times for a race and the distance the race takes place over

Part 1: For how many times can you win the race if your boat moves 1 m/s faster for every 1ms you wait before launching?

This is more of a math problem than a programming problem. The disance traveled based on how long you hold the button down is a quadratic formula. 

`x ( t - x ) - d` where x is the time you hold the button down, t is the total time for the race, and d is the distance of the race. If the answer is positive, that trial succeeds.

Part 2: Instead of a few entries on a race, the table is one big race and time. Solve the number of ways of winning this mega-race

Similar to part 1, but the size of the numbers and the fact that we need perfect, discrete percision means that we can't use a regular calculator and instead must use data structures equipped to handle numbers on the order of 10^15 (approx 2^50).

The final calculation uses C#'s BigInteger, which can be arbitrarily large (though Int64 would have provided enough precision) and requires an implementation of a square root estimator that can use the BigInteger. I wasn't sure how close the estimate would be, so I added code to push the intercepts up and down in case the end result was not quite accurate, but it turned out the estimations were only off by 1.