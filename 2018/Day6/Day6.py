import csv
import math

data = []
grid = []
number_close={}
infs = []

min_x = 1000
min_y = 1000
max_x = 0
max_y = 0

with open('day6.csv', 'r') as csvfile:
	myReader = csv.reader(csvfile)
	for row in myReader:
		data += [list(map(lambda x: int(x), row))]

def set_dists(points, x, y, dict):
	i = 0
	closest_val = 1000000
	closest_id = -1
	if dict == {}:
		while i < len(points):
			dict[i] = abs(points[i][0] - x) + abs(points[i][1] - y)
			if closest_val > dict[i]:
				closest_val = dict[i]
				closest_id = i
			elif closest_val == dict[i]:
				closest_id = -1
			i += 1
		dict['close'] = closest_id
		if closest_id in number_close:
			number_close[closest_id] += 1
		else:
			number_close[closest_id] = 1

def expand_top(grid, dimens):
	ret_list = []
	num = len(grid[0])
	i = 0
	dimens[1] -= 1
	while i < num:
		ret_list += [{}]
		i += 1
	grid = [ret_list] + grid
	i = 0
	while i < num:
		set_dists(data, i + dimens[0], dimens[1], grid[0][i])
		i += 1

def expand_bottom(grid, dimens):
	ret_list = []
	num = len(grid[0])
	i = 0
	dimens[3] += 1
	while i < num:
		ret_list += [{}]
		i += 1
	grid += [ret_list]
	i = 0
	while i < num:
		set_dists(data, i + dimens[0], dimens[1], grid[-1][i])
		i += 1

def check_expand(grid):
	i = 0
	top = False
	bottom = False
	left = False
	right = False
	while i < len(grid[0]):
		if(grid[0][i]['close'] != grid[1][i]['close'] and grid[0][i]['close'] != grid[2][i]['close']):
			top = True
		if(grid[-1][i]['close'] != grid[-2][i]['close'] and grid[-1][i]['close'] != grid[-3][i]['close']):
			bottom = True
		i+=1
	i = 0
	while i < len(grid):
		if grid[i][0]['close'] != grid[i][1]['close']:
			left = True
		if grid[i][-1]['close'] != grid[i][-2]['close']:
			right = True 
		i += 1
	return [top, right, bottom, left]

def set_infs(infs, grid):
	for top in grid[0]:
		if not top['close'] in infs:
			infs += [top['close']]
	for line in grid:
		if not line[0]['close'] in infs:
			infs += [line[0]['close']]
		if not line[-1]['close'] in infs:
			infs += [line[-1]['close']]
	for bottom in grid[-1]:
		if not bottom['close'] in infs:
			infs += [bottom['close']]

for point in data:
	if point[0] < min_x:
		min_x = point[0]
	if point[0] > max_x:
		max_x = point[0]
	if point[1] < min_y:
		min_y = point[1]
	if point[1] > max_y:
		max_y = point[1]

for point in data:
	point[0] -= min_x
	point[1] -= min_y

max_y -= min_y-1
max_x -= min_x-1

dimens = [min_x, min_y, max_x, max_y]

for i in range(max_x):
	grid += [[]]
	for j in range(max_y):
		grid[i] += [{}]
x = 0
while x < len(grid):
	y = 0
	while y < len(grid[0]):
		set_dists(data, x, y, grid[x][y])
		y += 1
	x += 1
go = True
m = 1000
i = 0
while go and i < m:
	go = False
	i += 1
	if i % 100 == 0:
		print(i)
	expanse = check_expand(grid)
	if(expanse[0]):
		expand_top(grid, dimens)
		#print("expanding top")
		go = True
	if(expanse[2]):
		expand_bottom(grid, dimens)
		#print("expanding bottom")
		go = True

print(check_expand(grid))
set_infs(infs, grid)
print(infs)
print(number_close)
for point in number_close:
	if point not in infs:
		print(point, number_close[point])