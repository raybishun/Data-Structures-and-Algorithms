import stack

my_str = "!dlroW olleH"
reversed_str = ""
s = stack.Stack()

for char in my_str:
    s.push(char)

while not s.is_empty():
    reversed_str += s.pop()

print(reversed_str)