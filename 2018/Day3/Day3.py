import csv

data = []
squares = 0
claims = {}

with open('day3.csv', 'r') as csvfile:
	myReader = csv.reader(csvfile)
	for row in myReader:
		data += [list(map(lambda x: int(x), row))]
		
for line in data:
	for x in range(line[3]):
		for y in range(line[4]):
			if (line[1]+x,line[2]+y) in claims:
				claims[(line[1]+x,line[2]+y)] += 1
			else:
				claims[(line[1]+x,line[2]+y)] = 1
				
for line in data:
	is_claim = True
	for x in range(line[3]):
		for y in range(line[4]):
			if claims[(line[1]+x,line[2]+y)] > 1:
				is_claim = False
	if is_claim:
		print(line[0])
		break
