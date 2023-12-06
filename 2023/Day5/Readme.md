# Day5

Input: A list of seeds and various mappings between source and destination values

Part 1: Based on the seeds and mappings, find the seed with the lowest location value

You apply a "map" operation to each seed, which modifies its value based on the mapping information. There are a lot of safeguards I put in place (not assuming a mapping was 1 to 1 and one seed could generate multiple points of data for the next step) that are overengineered for this problem. Given that a map will either have exactly 1 or 0 matches from a source to destination, keeping track of data in a List is completely unnecessary.

Part 2: The seeds in the seed list are actually pairs of the form (seed, range) where range is a number of seeds from the seed that exist

Instead of putting a single value through the mappings, we are now putting a range of values through the mappings. The good news is that from the learning in part 1, there are some assumptions that we can make to build the solution easier. Sadly, we cannot use the built-in Range data type in C#, since values can be larger than an int32.