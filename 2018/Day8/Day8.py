data = []

pointer_loc = 0
depth = 0
node_num = 0

current_pointer = 0
node_locs = {}

retval = 0

with open('day8.txt', 'r') as file:
	openString = file.read()
	data = map(lambda x: int(x), openString.split(" "))
	
while pointer_loc < len(data) and data!=[]:
	if data[pointer_loc] == 0:
		#print(pointer_loc)
		retval += sum(data[pointer_loc+2:pointer_loc+2+data[pointer_loc + 1]])
		i = 0
		while i < data[pointer_loc + 1]:
			data.pop(pointer_loc + 2)
			i += 1
		#print(data)
		data.pop(pointer_loc)
		data.pop(pointer_loc)
		#print(data)
		pointer_loc -= 2
	elif data[pointer_loc] > 0:
		data[pointer_loc] *= -1
	else:
		data[pointer_loc]
		
print(retval)