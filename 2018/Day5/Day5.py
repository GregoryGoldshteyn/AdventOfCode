import csv

original = ""
data = []
alphabet = 'abcdefghijklmnopqrstuvwxyz'
some_dict = {}

with open('day5.csv', 'r') as csvfile:
	myReader = csv.reader(csvfile)
	for row in myReader:
		original = row[0]

data = map(lambda x: x, original)
print(len(data))

def inc(d, k):
	if k in d:
		d[k] += 1
	else:
		d[k] = 1
		
length = len(data)
i = 0
reaction = True

def reacts(c1, c2):
	if c1.isupper() and c2.islower() and c2.upper() == c1:
		return True
	if c1.islower() and c2.isupper() and c1.upper() == c2:
		return True
	return False

lengths = {}
	
for ch in alphabet:
	data = map(lambda x: x, original)
	data = filter(lambda x: x != ch and x != ch.upper(), data)
	lengths[ch] = 0
	reaction = True
	length = len(data)
	while reaction:
		reaction = False
		i = 0
		while i < length - 1:
			if reacts(data[i], data[i + 1]):
				data.pop(i)
				data.pop(i)
				length -= 2
				reaction = True
			else:
				i += 1
	lengths[ch] = length
	print(ch, length)
	
smallest = 1000000
small_c = ""
for i in lengths:
	if lengths[i] < smallest:
		smallest = lengths[i]
		small_c = i
print(small_c, smallest)