import csv
from datetime import datetime

data = []

guards = {}

with open('day4.csv', 'r') as csvfile:
	myReader = csv.reader(csvfile)
	for row in myReader:
		data += [row]


#print(datetime.strptime(data[0][0], '%Y-%m-%d %H:%M'))
data.sort()

for t in data:
	if len(t) > 8:
		guard = t[6][1:]
	elif t[5] == 'falls':	
		sl = t[4]
	else:
		for x in range(int(sl), int(t[4])):
			if guard in guards:
				guards[guard] += [x]
			else:
				guards[guard] = [x]
				
sleepiest = 0
s_g = 0
for g in guards:
	if len(guards[g]) > sleepiest:
		sleepiest = len(guards[g])
		s_g = g

times = {}
for g in guards:
	for t in guards[g]:
		if (t, g) in times:
			times[(t, g)] += 1
		else:
			times[(t, g)] = 1

big = 0
big_t = 0

for t in times:
	if times[t] > big:
		big = times[t]
		big_t = t[0]
		b_g = t[1]

		
print(b_g)
print(big_t)
print(big_t*int(b_g))