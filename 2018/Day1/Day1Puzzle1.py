import csv

accum = 0
search = True
found = {0 : 1}
changes = []

with open('Day1Puzzle1Input.csv', 'r') as csvfile:
	myReader = csv.reader(csvfile)
	for row in myReader:
		if row[0][0] == '+':
			accum += int(row[0][1:])
			changes += [int(row[0][1:])]
		elif row[0][0] == '-':
			accum -= int(row[0][1:])
			changes += [int(row[0][1:]) * -1]
		if accum in found:
			print(accum)
			break
		found[accum] = 1

while search:
	for change in changes:
		accum += change
		if accum in found:
			search = False
			print(accum)
			break
		found[accum] = 1