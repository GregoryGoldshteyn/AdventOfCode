import csv

data = []

def find_differences(l1, l2):
	memory = {}
	def f_d(l1, l2, memory):
		if (l1, l2) in memory:
			return memory[(l1, l2)]
		if l1 == '':
			return 0
		if l1[0] == l2[0]:
			memory[(l1, l2)] = f_d(l1[1:], l2[1:], memory)
			return memory[(l1, l2)]
		else:
			memory[(l1, l2)] = f_d(l1[1:], l2[1:], memory) + 1
			return memory[(l1, l2)]
	return f_d(l1, l2, memory)

with open('day2.csv', 'r') as csvfile:
	myReader = csv.reader(csvfile)
	for row in myReader:
		data += row
		
for line in data:
	for line2 in data:
		if find_differences(line, line2) == 1:
			print(line)
			print(line2)