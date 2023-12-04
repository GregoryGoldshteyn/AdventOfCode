import csv
import math

close_ids = {}
infinite_points = []
data = []
total_dist_arr = [0]

min_x = 1000
min_y = 1000
max_x = 0
max_y = 0

with open('day6.csv', 'r') as csvfile:
	myReader = csv.reader(csvfile)
	for row in myReader:
		data += [list(map(lambda x: int(x), row))]
		
def calcDistance(x, y, point_x, point_y):
	return abs(x - point_x) + abs(y - point_y)
	
def distanceAllPoints(x, y, close_ids, total_dist_arr):
	least = -1
	chosen_point = -1
	min_dist = abs(x) + 1000 + abs(y) + 1000
	total = 0
	for point in close_ids:
		if point != -1:
			total += calcDistance(x, y, point[0], point[1])
			if calcDistance(x, y, point[0], point[1]) < min_dist:
				min_dist = calcDistance(x, y, point[0], point[1])
				chosen_point = point
			elif calcDistance(x, y, point[0], point[1]) == min_dist:
				chosen_point = -1
	close_ids[chosen_point] += 1
	if total < 10000:
		total_dist_arr[0] += 1
	return chosen_point
	
def determineInfs(close_ids):
	x = -700
	y = -700
	while x <= 700:
		distanceAllPoints(x, y, close_ids,total_dist_arr)
		x += 1
	print("end edge 1")
	while y <= 700:
		distanceAllPoints(x, y, close_ids,total_dist_arr)
		y += 1
	print("end edge 2")
	while x >= -700:
		distanceAllPoints(x, y, close_ids,total_dist_arr)
		x -= 1
	print("end edge 3")
	while y >= -700:
		distanceAllPoints(x, y, close_ids,total_dist_arr)
		y -= 1
	print("end edge 4")
	
#populate the ids of the close arrs
close_ids[-1] = 0
for point in data:
	close_ids[(point[0], point[1])] = 0
	
determineInfs(close_ids)
for point in close_ids:
	if close_ids[point] > 0:
		infinite_points += [point]
		
x = -700
y = -700

while x <=700:
	y = -700
	while y<=700:
		distanceAllPoints(x, y, close_ids, total_dist_arr)
		y+=1
	if x % 100 == 0:
		print x
	x+=1
	
for point in close_ids:
	if point not in infinite_points:
		print point
		print close_ids[point]
		
print total_dist_arr