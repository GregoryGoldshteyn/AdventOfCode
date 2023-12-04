import csv
import math

class worker:
	letter = ''
	time_left = 0
	is_busy = False

data = {}
alphabet = {}
letter_string = ""

working_letters = [''] * 5
workers = [0,1,2,3,4]
free_workers = 5
worker_times = [0]*5

timing_string = (' ' * 60) + ' ABCDEFGHIJKLMNOPQRSTUVWXYZ'

total_time = 0

with open('day7.csv', 'r') as csvfile:
	myReader = csv.reader(csvfile)
	for row in myReader:
		if row[1] in data:
			data[row[1]] += [row[0]]
		else:
			data[row[1]] = [row[0]]
		if row[0] not in alphabet:
			alphabet[row[0]] = 0
		if row[1] not in alphabet:
			alphabet[row[1]] = 0
			
print(len(data))
for letter in alphabet:
	if letter not in data:
		data[letter] = []

def decrement_workers(workers):
	i = 0
	done_workers = []
	while 0 not in workers:
		i = 0
		while i < len(workers):
			workers[i] -= 1
			i += 1
	i = 0
	while i < len(workers):
		if workers[i] <= 0:
			done_workers += [i]
	return done_workers
		
	
		
def determineNext(data):
	letters = []
	for letter in data:
		if data[letter] == []:
			letters += [letter]
	letters.sort()
	if len(letters) == 0:
		return ''
	return letters[0]
	
while len(letter_string) < 26:
	letter = determineNext(data)
	if free_workers > 0 and letter != '':
		working_letters[worker_times.index(0)] = letter
		worker_times[worker_times.index(0)] = timing_string.index(letter)
		print("Assigning", letter, timing_string.index(letter))
		print(worker_times)
		data.pop(letter)
		free_workers -= 1
	else:
		i = 0
		new_free = 0
		total_time += 1
		while i < len(worker_times):
			if worker_times[i] > 0:
				worker_times[i] -= 1
			if worker_times[i] == 0:
				new_free += 1
			i += 1
		if new_free != free_workers:
			i = 0
			while i < len(worker_times):
				if worker_times[i] == 0 and working_letters[i] != '':
					print("Finished with",working_letters[i])
					print(worker_times)
					letter_string += working_letters[i]
					for d in data:
						if working_letters[i] in data[d]:
							data[d].remove(working_letters[i])
						if data[d] == []:
							print("Newly freed", d)
					working_letters[i] = ''
				i += 1
			free_workers = new_free
			
print(len(letter_string))
print letter_string
print total_time